namespace Lesson7_函数
{
    internal class Program
    {
        //基本语法
        //
        //static 返回类型 函数名(参数类型 参数名1，参数类型 参数名2，……)
        //{ 
        //函数的代码逻辑;

        //return 返回值;（如果有返回类型才返回，是否需要写是可选的）
        //}


        //1.无参无返回值函数
        static void SayHellow()
        {
            Console.WriteLine("你好世界");
            return;//这个可以不写
        }

        //2.有参无返回值函数
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是{0}", name);
            return;//这个可以不写
        }

        //3.无参有返回值函数
        static string WhatYourName()
        {
            return "王大锤";
        }
        
        //4.有参有返回值函数
        static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
            //上面两句可以直接写成return a + b;
            //return后面可以跟表达式，只要表达式的结果跟函数返回值的类型一致即可
        }

        //5.有参有返回值函数
        static int[] Calc(int a, int b)
        { 
            int sum = a + b;
            int avg = sum / 2;
            //第一种return方式
            //int[] arr = new int[] { sum, avg };
            //return arr;

            //第二种return方式
            return new int[] { sum, avg };

            //注意不可以写的return方式
            //return { sum, avg };这种书写方式是错误的
        }

        static void Speak(string str)
        {
            if (str == "混蛋")
            {
                return;
            }
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("函数");
            //SayHellow();

            //string name = "王大锤";
            //SayYourName(name);

            //SayYourName(WhatYourName());

            //string str2 = WhatYourName();

            //WhatYourName();

            //Console.WriteLine(Sum(2, 3)) ;

            int[] arr = Calc(5, 7);
            Console.WriteLine(arr[0] + "  " + arr[1]);
        }
    }
}