namespace 测试专用
{
    internal class Program
    {

        static void Fun(int a)
        {
            if (a > 3)
            {
                return;
            }
            Console.WriteLine(a);
            ++a;
            Fun(a);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int a = 5;
            //string str = (a - 1) + "*" + a;
            //Console.WriteLine(str);

            Fun(0);
        }
    }
}