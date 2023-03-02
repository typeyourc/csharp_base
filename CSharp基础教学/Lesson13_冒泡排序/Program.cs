namespace Lesson13_冒泡排序
{
    internal class Program
    {
        #region 练习二-函数申明

        static void ArraySort(int[] arry, int sort)
        {
            switch (sort)
	        {
                case 1:
                    //冒泡排序-升序
                    int flag2 = 0;
                    for (int j = 0; j < arry.Length; j++)
                    {
                        flag2 = 0;
                        for (int i = 0; i < arry.Length - 1 - j; i++)
                        {
                            if (arry[i] > arry[i + 1])
                            {
                                flag2 = 1;

                                int temp;
                                temp = arry[i + 1];
                                arry[i + 1] = arry[i];
                                arry[i] = temp;
                            }
                        }
                        if (flag2 == 0)
                        {
                            break;
                        }
                    }
                        break;
                case 2:

                    //冒泡排序-降序
                    int flag3 = 0;
                    for (int j = 0; j < arry.Length; j++)
                    {
                        flag3 = 0;
                        for (int i = 0; i < arry.Length - 1 - j; i++)
                        {
                            if (arry[i] < arry[i + 1])
                            {
                                flag3 = 1;

                                int temp;
                                temp = arry[i + 1];
                                arry[i + 1] = arry[i];
                                arry[i] = temp;
                            }
                        }
                        if (flag3 == 0)
                        {
                            break;
                        }
                    }
                    break;
	        }
        }

        /// <summary>
        /// 排序方式枚举
        /// </summary>
        enum E_Sort
        {
            /// <summary>
            /// 升序
            /// </summary>
            Asc,
            /// <summary>
            /// 降序
            /// </summary>
            Desc
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序");

            #region 理论
            //int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //for (int m = 0; m < arr.Length - 1; m++)
            //{
            //    for (int i = 0; i < arr.Length - 1 - m; i++) 
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            int temp;
            //            temp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = temp;
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region 练习一

            //定义数组并赋值
            //int[] arr = new int[100];
            //Random random = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 101);
            //}

            //冒泡排序-升序
            //int flag = 0;
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    flag = 0;
            //    for (int i = 0; i < arr.Length - 1 - j; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            flag = 1;

            //            int temp;
            //            temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //    if (flag == 0) 
            //    {
            //        break;
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("{0}  ", arr[i]);
            //    if ((i + 1) % 10 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            //Console.WriteLine("-----------------------------------------");

            //冒泡排序-降序
            //int flag1 = 0;
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    flag1 = 0;
            //    for (int i = 0; i < arr.Length - 1 - j; i++)
            //    {
            //        if (arr[i] < arr[i + 1])
            //        {
            //            flag1 = 1;

            //            int temp;
            //            temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //    if (flag1 == 0)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("{0}  ", arr[i]);
            //    if ((i + 1) % 10 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            #endregion

            #region 练习二

            //定义数组并赋值
            int[] arr = new int[100];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 101);
            }

            //调用函数升序
            ArraySort(arr,1);

            //打印
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("-----------------------------------------");

            //调用函数降序
            ArraySort(arr, 2);

            //打印
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            #endregion

        }
    }
}

//test git email