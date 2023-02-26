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

            //遍历交错数组，并打印


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "  ");
                }
                Console.WriteLine();
            }

            //增加交错数组的元素
            //1.定义新数组，
            int[][] array1 = {new int[] {1, 2,3},
                              new int[] {4, 5},
                              new int[] {6}};

            //2.打印新数组
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1[i].Length; j++)
                {
                    Console.Write(array1[i][j] + "  ");
                }
                Console.WriteLine();
            }

            //3.老数组等于新数
            array = array1;

            //4.打印老数组
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "  ");
                }
                Console.WriteLine();
            }


            //减少交错数组的元素
            //1.定义新数组
            int[][] array2 = {new int[] {1, 2,3}};

            //2.老数组等于新数组
            array = array2;

            //3.打印老数组
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}