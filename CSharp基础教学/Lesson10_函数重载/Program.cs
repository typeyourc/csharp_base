namespace Lesson10_函数重载
{
    internal class Program
    {

        //参数数量不同
        static int Sum(int a, int b)
        {
            return a + b;
        }

        //参数数量不同
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        //数量相同 类型不同1
        static float Sum(float a, float b)
        {
            return a + b;
        }

        //数量相同 类型不同2
        static float Sum(int a, float f)
        {
            return a + f;
        }

        //数量相同 顺序不同
        static float Sum(float f, int a)
        {
            return f + a;
        }

        //ref和out
        static float Sum(ref float f, int a)
        {
            return f + a;
        }

        //练习一
        static int Compare(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }

        static float Compare(float a, float b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }

        static double Compare(double a, double b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }

        //练习二
        static int NCompare(params int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static float NCompare(params float[] a)
        {
            float max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static double NCompare(params double[] a)
        {
            double max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("函数重载");

            Console.WriteLine(Compare(1, 2));
            Console.WriteLine(Compare(1.1f, 2.2f));
            Console.WriteLine(Compare(1.1, 2.2));


            //Console.WriteLine(NCompare(new int[] { 1, 2, 3 })) ;
            //Console.WriteLine(NCompare(new float[] { 1.1f, 2.2f, 3.3f }));
            //Console.WriteLine(NCompare(new double[] { 5.1, 6.2, 7.3 }));

            Console.WriteLine(NCompare(1, 2, 3));
            Console.WriteLine(NCompare(1.1f, 2.2f, 3.3f));
            Console.WriteLine(NCompare(5.1, 6.2, 7.3));
        }
    }
}