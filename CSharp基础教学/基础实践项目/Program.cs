using System.Data.SqlTypes;

namespace 基础实践项目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 控制台初始设置
            //x轴50，y轴30，窗口和缓冲区
            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);

            //光标不可见
            Console.CursorVisible = false;

            //清理窗口
            Console.Clear();
            #endregion

 
            #region 游戏场景一：首页

            //申明光标位置变量
            int x = 0, y = 0;
            
            //打印标题-飞行棋
            x = 22; y = 7;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("飞行棋");

            //打印选项-开始游戏
            x = 20; y = 12;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("开始游戏(w)");

            //打印选项-退出游戏
            x = 20; y = 14;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("退出游戏(s)");

            //打印帮助信息
            x = 5; y = 18;
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
                x = 20; y = 12;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("开始游戏(w)");

                //打印选项-退出游戏
                x = 20; y = 14;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("退出游戏(s)");

                //打印帮助信息
                x = 5; y = 18;
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
                x = 20; y = 12;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("开始游戏(w)");

                //打印选项-退出游戏
                x = 20; y = 14;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("退出游戏(s)");

                //打印帮助信息
                x = 5; y = 18;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("**请按w和s键选择开始或退出，按回车生效**");

                //让系统自己的信息不显示出来
                Console.ForegroundColor = ConsoleColor.Black;
            }

            int asciiInput = Convert.ToInt32(input);

            if ( isStart == true && asciiInput == 13)
            {
                Console.Clear();
            }
            else if (isStart == false && asciiInput == 13)
            {
                Environment.Exit(0);
            }
            }

           

            #endregion


        }
    }
}