namespace Lesson4_交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");

            int[][] array = {new int[] {1, 2,3},
                             new int[] {4, 5}};

            //数组的长度-行
            Console.WriteLine(array.GetLength(0));

            //数组的长度-列
            Console.WriteLine(array[0].Length);

            //遍历交错数组

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {

                }
            }
        }
    }
}