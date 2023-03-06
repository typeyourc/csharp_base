﻿using System;
using System.Data.SqlTypes;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;

namespace 基础实践项目
{
    #region 格子类型枚举申明
    /// <summary>
    /// 特殊类型格子
    /// </summary>
    enum E_Type
    {
        /// <summary>
        /// 普通
        /// </summary>
        Common,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 炸弹
        /// </summary>
        Bomb,
        /// <summary>
        /// 时空隧道
        /// </summary>
        Tunnel
    }
    #endregion

    #region 玩家结构体申明

    struct Gamer
    {
        public int typePlayer;//玩家种类，0为真人玩家，1为电脑
        public int index;//玩家位置索引
        public bool canPlay;//玩家接下来是否可以扔色子标志
        public int r;//扔色子得到的随机数1~6

        //仍色子函数
        public void randomThrow()
        {
            ////Random  random = new Random();
            //return (new Random()).Next(1, 7);

            ////玩家或者电脑色子扔出随机数n 1~6
            //int n = P1.randomThrow();

            //P1.index = P1.index + n;

            //玩家或者电脑色子扔出随机数n 1~6后，新的位置
            Random random = new Random();
            r = random.Next(1, 7);
            index = index + r;
        }

        //构造函数
        public Gamer(int typePlayer, int index, bool canPlay, int r = 0)
        {
            this.typePlayer = typePlayer;
            this.index = index;
            this.canPlay = canPlay;
            this.r = r;
        }
    }
    #endregion

    internal class Program
    {

        #region 2.2.2地图元素属性存储到数组中函数申明
        //元素存储函数定义
        static void StoreMapElement(int type, int[,] arr1, params int[] arr2)
        {
            //将地图元素存储到数组中
            int count = 1;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.Length; k++)
                    {
                        if (count == arr2[k])
                        {
                            arr1[i, 2] = type;
                            break;
                            //测试存入暂停是否正确-测试通过
                            //Console.WriteLine(i + " " + j + " " + arr1[i, j] + "--" + count);
                        }
                    }
                    
                }
                ++count;
            }

        }

        #endregion

        #region 2.3确认玩家最终索引函数申明

        static void changeIndex(ref Gamer nowPlayer,ref Gamer waitPlayer, int[,] arr)
        {
            //判断索引变化后的新索引对应的格子属性
            if (arr[nowPlayer.index, 2] == 0)//普通格子
            {
                nowPlayer.index = nowPlayer.index;
                return;
            }
            else if (arr[nowPlayer.index, 2] == 1)//暂停格子
            {
                nowPlayer.index = nowPlayer.index;
                nowPlayer.canPlay = false;
                return;
            }
            else if (arr[nowPlayer.index, 2] == 2)//炸弹格子
            {
                nowPlayer.index = nowPlayer.index - 5;
                return;
            }
            else if(arr[nowPlayer.index, 2] == 3)//时空隧道
            {
                //时空隧道，三种情况(随机倒退1/暂停2/换位置3)
                int r1 = (new Random()).Next(1, 4);
                if (r1 == 1)//随机倒退
                {
                    int r2 = (new Random()).Next(1, 7);//随机倒退1~6步
                    nowPlayer.index = nowPlayer.index - r2;
                    //需要传入进一步判断格子属性
                    changeIndex(ref nowPlayer, ref waitPlayer, arr);
                }
                else if (r1 == 2)//暂停
                {
                    nowPlayer.index = nowPlayer.index;
                    nowPlayer.canPlay = false;
                    return;
                }
                else if (r1 == 3)//换位置
                {
                    int temp;
                    temp = nowPlayer.index;
                    nowPlayer.index = waitPlayer.index;
                    waitPlayer.index = temp;
                    return;
                }
            }
        }
        #endregion

        #region 2.3地图上打印玩家logo函数申明

        static void printPlayer(int type, Gamer nowPlayer,int[,] arr)
        {
            Console.SetCursorPosition(arr[nowPlayer.index,0],arr[nowPlayer.index,1]);
            switch (type)
            {
               case 0:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("▲");
                    break;
            }
           
        }
        #endregion

        #region 2.3战斗信息区打印战斗信息函数

        static void battleInfo(int type, Gamer nowPlayer)
        {
            //打印扔出色子点数
            Console.Write("你扔出点数为：{0}", nowPlayer.r);
            //打印色子点数位置信息

            //打印继续战斗信息

        }
        #endregion
        static void Main(string[] args)
        {
            #region 控制台初始设置
            //x轴50，y轴30，窗口和缓冲区
            //+8是为了防止控制台自己输出的信息，影响程序正常输入的信息的显示
            int w = 50, h = 30;
            Console.SetWindowSize(w, h + 10);
            Console.SetBufferSize(w, h + 10);

            //光标不可见
            Console.CursorVisible = false;

            //清理窗口
            Console.Clear();
            #endregion

            #region 场景id初始设置
            //1表示游戏场景一，2表示游戏场景二
            int sceneId = 1;
            #endregion

            #region 游戏场景1：首页

            //申明光标位置变量
            int x = 0, y = 0;

            //打印标题-飞行棋
            x = w / 2 - 3; y = 7;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("飞行棋");

            //打印选项-开始游戏
            x = w / 2 - 5; y = 12;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("开始游戏(w)");

            //打印选项-退出游戏
            x = w / 2 - 5; y = 14;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("退出游戏(s)");

            //打印帮助信息
            x = w / 2 - 20; y = 18;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**请按w和s键选择开始或退出，按回车生效**");

            //实现选项可选(默认停留在开始游戏上)
            //选项标志位
            bool isStart = true;

            //循环检测输入
            while (true)
            {
                //检测输入
                char input = Console.ReadKey(true).KeyChar;
                if (input == 'w')
                {

                    //标志位更新
                    isStart = true;

                    //打印选项-开始游戏
                    x = w / 2 - 5; y = 12;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("开始游戏(w)");

                    //打印选项-退出游戏
                    x = w / 2 - 5; y = 14;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("退出游戏(s)");

                    //打印帮助信息
                    x = w / 2 - 20; y = 18;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**请按w和s键选择开始或退出，按回车生效**");

                    //让系统自己的信息不显示出来
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else if (input == 's')
                {
                    //标志位更新
                    isStart = false;

                    //打印选项-开始游戏
                    x = w / 2 - 5; y = 12;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("开始游戏(w)");

                    //打印选项-退出游戏
                    x = w / 2 - 5; y = 14;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("退出游戏(s)");

                    //打印帮助信息
                    x = w / 2 - 20; y = 18;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**请按w和s键选择开始或退出，按回车生效**");

                    //让系统自己的信息不显示出来
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                //回车键输入判断
                int asciiInput = Convert.ToInt32(input);

                if ( isStart == true && asciiInput == 13)
                {
                    sceneId = 2; 
                    Console.Clear();
                }
                else if (isStart == false && asciiInput == 13)
                {
                    Environment.Exit(0);
                }
                if (sceneId == 2)
                {
                    break;
                }
            }

            #endregion

            #region 游戏场景2：游戏中页面

            #region 2.1绘制城墙

            Console.ForegroundColor = ConsoleColor.Red;
            //绘制4个x轴的墙
            for (int i = 0; i < w - 1; i += 2)
            {
                Console.SetCursorPosition(i, h - 30);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 11);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 6);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 1);
                Console.Write("■");
            }

            //绘制亮个y轴的墙
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }


            #endregion

            #region 2.2游戏地图
            #region 2.2.0地图初始设置
            //地图坐标,初始坐标(14,3)
            int xMap = 14;
            int yMap = 3;
            //地图元素个数，一共80个
            int numMap = 80;
            int[,] array = new int[80, 3];
            #endregion

            #region 2.2.1地图元素坐标存到数组中
            #region 2.2.1.1改进前坐标存数组方法
            ////第一行+第二行地图元素存到数组中
            //for (int i = 0; i < 11; i++)
            //{
            //    array[i, 0] = xMap;
            //    array[i, 1] = yMap;
            //    array[i, 2] = 0;

            //    if (xMap <= 34)
            //    {
            //        xMap += 2;
            //    }
            //    else
            //    {
            //        yMap += 1;
            //    }
            //}
            //yMap += 1;
            ////第三行+第四行地图元素存到数组中
            //for (int i = 11; i < 22; i++)
            //{
            //    array[i, 0] = xMap;
            //    array[i, 1] = yMap;
            //    array[i, 2] = 0;

            //    if (xMap >= 16)
            //    {
            //        xMap -= 2;
            //    }
            //    else
            //    {
            //        yMap += 1;
            //    }
            //}

            ////第五行+第六行地图元素存到数组中
            //for (int i = 22; i < 33; i++)
            //{
            //    array[i, 0] = xMap;
            //    array[i, 1] = yMap;
            //    array[i, 2] = 0;

            //    if (xMap <= 34)
            //    {
            //        xMap += 2;
            //    }
            //    else
            //    {
            //        yMap += 1;
            //    }
            //}
            #endregion
            #region 2.2.1.2改进后坐标存数组方法
            //存储方法改进(写入一个循环中)
            for (int i = 0; i < 80; i++)
            {
                if (i < 12 || i >= 23 && i < 34 || i >= 45 && i < 56 || i >= 67 && i < 78)
                {
                    array[i, 0] = xMap;
                    array[i, 1] = yMap;
                    array[i, 2] = 0;

                    if (xMap < 34)
                    {
                        xMap += 2;
                    }
                    else
                    {
                        yMap += 1;
                    }
                }
                if (i >= 12 && i < 23 || i >= 34 && i < 45 || i >= 56 && i < 67 || i == 78 || i == 79)
                {
                    array[i, 0] = xMap;
                    array[i, 1] = yMap;
                    array[i, 2] = 0;

                    if (xMap > 16)
                    {
                        xMap -= 2;
                    }
                    else
                    {
                        yMap += 1;
                    }
                }

            }
            //测试一下存储是否正确-测试通过
            //for (int i = 0; i < 79; i++)
            //{
            //    Console.WriteLine(i + " "+ array[i, 0] + " " + array[i, 1] + " " + array[i, 2]);
            //}
            #endregion

            #endregion

            #region 2.2.2地图元素属性存储到数组中
            //属性分3种，普通0、暂停1、炸弹2、时空隧道3
            //普通在2.1.1中已经存储，无需再存
            #region 2.2.2.1改进前存储方法
            //注意，因为原先地图元素个数是79个，后面个数改为80个，所以下面的数都需要加1，这个方法中以下未修改
            //暂停，地图中一共5个，坐标分别为数组第9/49/50/62/68个元素
            //int countPause = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (countPause == 9 || countPause == 49 || countPause == 50 || countPause == 62 || countPause == 68)
            //        {
            //            array[i, j] = 1;
            //            //测试存入暂停是否正确-测试通过
            //            //Console.WriteLine(i + " " + j + " " + array[i, j] + "--" + countPause);
            //        }
            //        ++countPause;
            //    }
            //}
            ////炸弹，地图中一共2个，坐标分别为数组第26/57个元素
            //int countBomb = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (countBomb == 26 || countBomb == 57)
            //        {
            //            array[i, j] = 2;
            //            //测试存入炸弹是否正确-测试通过
            //            //Console.WriteLine(i + " " + j + " " + array[i, j] + "--" + countBomb);
            //        }
            //        ++countBomb;
            //    }
            //}

            ////时空隧道，地图中一共11个，坐标分别为数组第11/12/16/18/32/45/47/56/66/77个元素
            //int countTunnel = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (countTunnel == 11 || countTunnel == 12 || countTunnel == 16 || countTunnel == 18 || countTunnel == 32 || countTunnel == 45 || countTunnel == 47 || countTunnel == 56 || countTunnel == 66 || countTunnel == 77)
            //        {
            //            array[i, j] = 3;
            //            //测试存入时空隧道否正确 - 测试通过
            //            //Console.WriteLine(i + " " + j + " " + array[i, j] + "--" + countTunnel);
            //        }
            //        ++countTunnel;
            //    }
            //}
            #endregion

            #region 2.2.2.2改进后存储方法
            //利用函数改进上述存储过程
            StoreMapElement(1, array, new int[] { 10, 50, 51, 63, 69 });
            StoreMapElement(2, array, new int[] { 27, 58 });
            StoreMapElement(3, array, new int[] { 12, 13, 17, 19, 33, 37, 46, 48, 57, 67, 78 });

            #endregion

            #endregion

            #region 2.2.3输出地图
            #region 2.2.3.1定义类型对应的logo并输出地图
            
            //输出地图
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //设置输出坐标
                    Console.SetCursorPosition(array[i, 0], array[i, 1]);
                    switch ((E_Type)array[i, 2])
                    {
                        case E_Type.Common:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("□");
                            break;
                        case E_Type.Pause:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("‖");
                            break;
                        case E_Type.Bomb:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("●");
                            break;
                        case E_Type.Tunnel:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("¤");
                            break;
                        default:
                            break;
                    }
                }
            }
            //设置坐标，消除控制台自动输出信息对正常输入的影响
            Console.SetCursorPosition(0,h);

            #endregion

            #endregion

            #region 2.2.4说明信息输出

            //输出普通格子info
            Console.SetCursorPosition(2, h - 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("□:普通格子");
            //输出暂停info
            Console.SetCursorPosition(2, h - 9);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("‖:暂停，一回合不动");
            //输出炸弹info
            Console.SetCursorPosition(27, h - 9);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("●:炸弹，倒退5格");
            //输出时空隧道info
            Console.SetCursorPosition(2, h - 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤:时空隧道，随机倒退，暂停，换位置");
            //输出玩家info
            Console.SetCursorPosition(2, h - 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("★:玩家");
            //输出电脑info
            Console.SetCursorPosition(12, h - 7);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("▲:电脑");
            //输出电脑玩家重合info
            Console.SetCursorPosition(22, h - 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("◎:玩家电脑重合");

            //设置坐标，消除控制台自动输出信息对正常输入的影响
            Console.SetCursorPosition(0, h);

            #endregion

            #endregion

            #region 2.3回合战斗
            //玩家初始化
            Gamer P1 = new Gamer(0, -1, false);//玩家
            Gamer P2 = new Gamer(1, -1, false);//电脑

            //开始游戏
            Console.SetCursorPosition(2, h - 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("按任意键开始扔色子");

            while (true)
            {              
              
                //玩家先扔色子和改变索引
                P1.randomThrow();//P1扔色子
                changeIndex(ref P1, ref P2, array);//确认P1最终索引
                printPlayer(0, P1, array);//在新索引处打印玩家logo

                
                Console.ReadKey();

                //电脑再扔色子和改变索引
                P2.randomThrow();//P2扔色子
                changeIndex(ref P2, ref P1, array);//确认P2最终索引
                printPlayer(1, P2, array);//在新索引处打印电脑logo

                Console.ReadKey();
            }


            #endregion

            #endregion

        }
    }
}