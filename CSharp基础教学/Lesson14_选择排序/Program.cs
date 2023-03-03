namespace Lesson14_选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序");

            //练习
            //1.定义数组并赋值

            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 101);
            }

            //int[] arr = new int[20] { 19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0};

            //打印原始数组
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\n-------------------------------------------------");

            //一共比较m轮
            for (int m = 0; m < arr.Length - 1; m++)
            {
                //2.快排-升序排序并打印

                //建个中间商
                int index = 0;

                //单论比较

                for (int i = 1; i < arr.Length - m; i++)
                {
                    if (arr[index] < arr[i])
                    {
                        index = i;
                    }
                }

                //单论比较结束，最大数移到最后，最后数移到index处
                if (index != arr.Length - 1 - m)
                {
                    int temp;
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - 1 - m] = temp;
                }

            }

            //打印排序后数组
            for(int i = 0;i < arr.Length; i++) 
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}