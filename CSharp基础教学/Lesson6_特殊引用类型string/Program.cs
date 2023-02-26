namespace Lesson6_特殊引用类型string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("特殊引用类型string");


            ////string str1 = "123";
            ////string str2 = str1;

            ////str2 = "321";

            ////Console.WriteLine(str1);
            ////Console.WriteLine(str2);


            int[] a = new int[] { 10 };
            int[] b = a;

            b = new int[5];

            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);

        }
    }
}