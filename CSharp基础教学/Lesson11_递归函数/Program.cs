using System.Reflection.Metadata.Ecma335;

namespace Lesson11_递归函数
{
    
    
    internal class Program
    {
        //练习一：使用递归的方式打印0~10
        //static void PrintNum(int a)
        //{
        //    if (a > 10)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(a);
        //    ++a;
        //    PrintNum(a);
        //}

        //练习二：传入一个值，递归计算该值的阶乘，并返回，5！=1*2*3*4*5
        //错误的计算方法
        //static void CalcFact(int a, int i = 1)
        //{
        //    int fact = i * (i + 1);
        //    if (i + 1 <= a)
        //    {
        //        ++i;
        //        Console.Write(fact + "  ");
        //        CalcFact(a, i);
        //    }
        //    else
        //    {
        //        Console.WriteLine(fact);
        //    }
        //}
        
        //正确方法一：
        static void CalcFact(long a, long fact = 1)
        {
            if (a >= 1)
            {
                fact = fact * a ;
                --a;
            }
            else
            {
                Console.WriteLine(fact);
                return;
            }

            CalcFact(a,fact);
        }

        //正确方法二：老师方法
        static int CalcFact(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * CalcFact(a - 1);
        }

        //练习三：使用递归求1！+2！+ ……10！

        //正确方法一：
        static void SumFact(int a,int sum = 0)
        {
            int fact = 1;

            if (a >= 1)
            {
                for (int i = 2; i <= a; i++)
                {
                    fact = fact * i;
                }

                sum += fact;
                --a;

                SumFact(a, sum);
            }
            else
            {
               Console.WriteLine(sum);
            }

        }

        //正确方法二：
        static int SumFact(int a)
        {
            if (a == 1)
            {
                return CalcFact(1);
            }
            --a;
            return CalcFact(a + 1) + SumFact(a);
        }

        //练习四：竹竿100m,每天砍一半，第10天长度是多少，从第0天开始
        static void CutBam(float changDu, int Days)
        {
            if (Days >= 1)
            {
                changDu = changDu / 2;
                --Days;
                CutBam(changDu, Days);
            }
            else
            {
                Console.WriteLine(changDu);
            }
        }

        //练习五：打印1~200，不允许使用循环和条件语句

        //使用条件语句版本
        //static void Print(int a = 1)
        //{
        //    if (a <= 200)
        //    {
        //        Console.Write(a + "  ");
        //        ++a;
        //        Print(a);
        //    }
        //    else
        //    {
        //        return;
        //    }

        //}

        //错误版本
        //static void Print(int a = 0)
        //{
        //    Console.Write(((a < 200) ? (a + 1) : 1) + "  ");
        //        ++a;
        //        Print(a);
        //}

        //我写的错误版本
        //static bool Sum(int n)
        //{
        //    Console.WriteLine(n);
        //    ++n;
        //    return (n == 200 || Sum(n + 1));
        //}

        //老师写的版本
        static bool Sum(int n)
        {
            Console.WriteLine(n);
            return (n == 200 || Sum(n + 1));
        }

        //自增练习：斐波那契数列1、1、2、3、5、8……数列 F(n) = F(n-1) + F(n-2)
        static int F(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else if (num == 1)
            {
                return 2;
            }
            return F(num - 1) + F(num - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("递归函数");

            //练习一
            //PrintNum(0);

            //练习二
            //CalcFact(10);

            //练习三-结果为4037913
            //Console.WriteLine(SumFact(3));

            //练习四-结果为0.09765625
            //CutBam(100, 11);

            //练习五
            //Print();
            //Sum(1);

            //自增练习
            Console.WriteLine(F(9));
        }
    }
}