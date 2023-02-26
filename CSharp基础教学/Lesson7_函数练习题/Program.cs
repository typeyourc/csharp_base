namespace Lesson7_函数练习题
{
    internal class Program
    {

        //练习一：比较连个数字大小的函数
        static int BigNum(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }

        //练习二：求圆的面积和周长，并返回打印
        static float[] CalcCircle(float r)
        {
            const float PI = 3.1415f;
            return new float[] { 2 * PI * r, PI * r * r };
        }

        //练习三：求数组的总和、最大、最小、平均值
        /// <summary>
        /// 返回数组元素总和、最大、最小、平均值
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static float[] CalcArray(float[] a)
        {
            float sum = 0;
            float min = 0, max = 0, avg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (i == 0) 
                {
                    min = a[i];
                    max = a[i];
                }
                else
                {
                    if (min >= a[i])
                    {
                        min = a[i];
                    }
                    if (max <= a[i])
                    { 
                        max = a[i];
                    }
                }
            }
            avg = sum / a.Length;

            return new float[] { sum, min, max, avg };
        }

        //练习四：判断输入是否是质数
        static void PrimeNumber(uint a)
        {
            if (a == 1 || a == 0)
            {
                Console.WriteLine("你输入的数字{0}不是质数",a);
            }
            else 
            {
                bool flag = true;
                int zhengChu = 0;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0 && a != 2)
                    {
                        flag = false;
                        zhengChu = i;
                        //Console.WriteLine("你输入的数字{0}不是质数，它至少被{1}整除", a, i);
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("你输入的数字{0}不是质数，它至少被{1}整除", a, zhengChu);
                }
                else
                {
                    Console.WriteLine("你输入的数字{0}是质数", a);
                }
            }
        }

        //练习五：判断是否是闰年
        static void LeapYear(uint a)
        {
            //if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
            //{
            //    Console.WriteLine("{0}是闰年", a);
            //}
            //else
            //{
            //    Console.WriteLine("{0}不是闰年", a);
            //}

            Console.WriteLine("{0}{1}", a, (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0)) ? "是闰年" : "不是闰年");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //练习一
            //Console.WriteLine(BigNum(189, 1));

            //练习二
            //try
            //{
            //    float r = float.Parse(Console.ReadLine());
            //    CalcCircle(r);
            //    float[] arr = CalcCircle(r);
            //    Console.WriteLine(arr[0] + "  " + arr[1]);

            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            ////练习三
            //float[] arr3 = { 1.5f, 2.5f, 3.5f };
            //Console.WriteLine(CalcArray(arr3)[0] + "  " + CalcArray(arr3)[1] + "  " + CalcArray(arr3)[2] + "  " + CalcArray(arr3)[3]);


            //练习四
            //try
            //{
            //    uint a = uint.Parse(Console.ReadLine());
            //    PrimeNumber(a);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("请输入大于0的正数");
            //}

            //练习五
            try
            {
                LeapYear(uint.Parse(Console.ReadLine()));
            }
            catch (Exception)
            {
                Console.WriteLine("请输入正确的年份");
            }

        }
    }
}