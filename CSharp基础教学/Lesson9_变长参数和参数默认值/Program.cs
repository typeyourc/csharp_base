namespace Lesson9_变长参数和参数默认值
{

    internal class Program
    {
        static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Speak(string str = "我是唐老师")
        { 
            Console.WriteLine(str);
        }

        static void Speak2(string a, string test, string name = "唐老师", string str = "我没什么可说的")
        {

        }

        //练习一：用params,求多个数的和及平均数
        static void CalcNums(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            int avg = sum / a.Length;
            Console.WriteLine(sum + "  " + avg);
        }

        //练习二：求多个数字的偶数和、奇数和

        static void CalcSum(params int[] a)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    evenSum += a[i];
                }
                else
                {
                    oddSum  += a[i];
                }
            }
            Console.WriteLine(evenSum + "  " + oddSum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("变长参数和参数默认值");

            Console.WriteLine(Sum(new int[] { 1, 2, 3, 4, 5 }));

            Speak();
            Speak("哈哈，我是唐老湿");

            //练习一：调用
            CalcNums(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) ;

            //练习二：调用
            CalcSum(new int[] { 1, 2, 3, 4, 5 });
        }
    }
}