namespace Lesson13_冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序");

            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };



            for (int m = 0; m < arr.Length - 1; m++)
            {
                for (int i = 0; i < arr.Length - 1 - m; i++) 
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

//test git email