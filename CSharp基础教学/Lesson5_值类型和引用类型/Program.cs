namespace Lesson5_值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");

            //练习一

            //int a = 10;
            //int b = a;
            //b = 20;

            //Console.WriteLine(a);

            //练习二
            //int[] a = new int[] { 10 };
            //int[] b = a;

            //b[0] = 20;
            //Console.WriteLine(a[0]);

            //练习三
            string str = "123";
            string str2 = str;
            str2 = "321";
            Console.WriteLine(str);

        }
    }
}