using System.Data.SqlTypes;
using System.IO.MemoryMappedFiles;

namespace 基础实践项目
{
    internal class Program
    {

        #region 2.2.2地图元素属性存储到数组中
        //存储函数定义
        static void StoreMapElement(int type, int[,] arr1, params int[] arr2)
        {
            //将地图元素存储到数组中

        }

        #endregion
        static void Main(string[] args)
        {
            #region 控制台初始设置
            //x轴50，y轴30，窗口和缓冲区
            //+8是为了防止控制台自己输出的信息，影响程序正常输入的信息的显示
            int w = 50, h = 30;
            Console.SetWindowSize(w, h + 8);
            Console.SetBufferSize(w, h + 8);

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

            Console.Clear();
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

            //地图坐标,初始坐标(16,3)
            int xMap = 16;
            int yMap = 3;
            //地图元素个数，一共79个
            int numMap = 79;
            int[,] array = new int[79, 3];

            #region 2.2.1地图元素坐标存到数组中
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

            //存储方法改进(写入一个循环中)
            for (int i = 0; i < 79; i++)
            {
                if (i < 11 || i >= 22 && i < 33 || i >= 44 && i < 55 || i >= 66 && i < 77)
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
                if (i >= 11 && i < 22 || i >= 33 && i < 44 || i >= 55 && i < 66 || i == 77 || i == 78) 
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

            #region 2.2.2地图元素属性存储到数组中
            //属性分3种，普通0、暂停1、炸弹2、时空隧道3
            //普通在2.1.1中已经存储，无需再存

            //暂停，地图中一共5个，坐标分别为数组第9/49/50/62/68个元素
            int countPause = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (countPause == 9 || countPause == 49 || countPause == 50 || countPause == 62 || countPause == 68)
                    {
                        array[i, j] = 1;
                        //测试存入暂停是否正确-测试通过
                        //Console.WriteLine(i + " " + j + " " + array[i, j] + "--" + countPause);
                    }
                    ++countPause;
                }
            }
            //炸弹，地图中一共2个，坐标分别为数组第26/57个元素
            int countBomb = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (countBomb == 26 || countBomb == 57)
                    {
                        array[i, j] = 2;
                        //测试存入炸弹是否正确-测试通过
                        //Console.WriteLine(i + " " + j + " " + array[i, j] + "--" + countBomb);
                    }
                    ++countBomb;
                }
            }

            //时空隧道，地图中一共11个，坐标分别为数组第11/12/16/18/32/45/47/56/66/77个元素
            int countTunnel = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (countTunnel == 11 || countTunnel == 12 || countTunnel == 16 || countTunnel == 18 || countTunnel == 32 || countTunnel == 45 || countTunnel == 47 || countTunnel == 56 || countTunnel == 66  || countTunnel == 77)
                    {
                        array[i, j] = 3;
                        //测试存入时空隧道否正确 - 测试通过
                        //Console.WriteLine(i + " " + j + " " + array[i, j] + "--" + countTunnel);
                    }
                    ++countTunnel;
                }
            }

            //利用函数改进上述存储过程



            #endregion


            #endregion

            #endregion

        }
    }
}