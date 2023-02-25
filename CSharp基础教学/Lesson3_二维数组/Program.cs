using System.Xml.Linq;

namespace Lesson3_二维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("二维数组");

            //int[,] array = new int[,] { { 1, 2, 3 }, 
            //                            { 4, 5, 6 } };


            ////得到多少行
            //Console.WriteLine(array.GetLength(0));
            ////得到多少列
            //Console.WriteLine(array.GetLength(1)); 

            #region 练习一

            //int[,] array1 = new int[100, 100];
            //int num = 1;

            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        array1[i,j] = num;
            //        num++;
            //        if (array1[i,j] % 1000 == 0) 
            //        {
            //            Console.WriteLine(array1[i, j]);  
            //        }
            //    }
            //}



            #endregion

            #region 练习二

            //生成并打印4x4二维随机数列
            //int[,] array2 = new int[4,4];

            //Random random = new Random();

            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        int r = random.Next(1, 101);
            //        if (j >= i)
            //        {
            //            array2[i, j] = 0;

            //        }
            //        else
            //        {
            //            array2[i, j] = r;
            //        }

            //        //设置打印坐标，让输出的时候，左边对齐
            //        Console.SetCursorPosition(4 * j, i) ;

            //        Console.Write("{0}",array2[i, j]);
            //    }
            //    if (i < array2.GetLength(0) - 1)
            //    {
            //        Console.Write("\n");

            //    }

            //}


            #endregion

            #region 练习三

            ////生成1个3x3随机数二维数组
            //int[,] array3 = new int[3, 3];
            //Random random = new Random();
            ////两条对角线
            //int sum1 = 0;
            //int sum2 = 0;

            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        array3[i, j] = random.Next(1, 11);

            //        if (i == j)
            //        {
            //            sum1 = sum1 + array3[i, j];
            //        }


            //        //设置打印坐标让输出的时候元素对齐
            //        Console.SetCursorPosition(4 * j, i);

            //        Console.Write(array3[i, j]);
            //    }
            //    //每行末尾输出一个回车换行
            //    if (i < array3.GetLength(0))
            //    {
            //        Console.WriteLine();
            //    }

            //}

            ////另一条对角线的关系是，坐标相加等于长度-1，是个固定值
            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        if (i + j == array3.GetLength(0) - 1 && i != j)
            //        { 
            //            sum2 = sum2 + array3[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine(sum1+sum2);
            #endregion

            #region 练习四

            ////申明5x5随机数组
            //int[,] array4 = new int[20, 20];

            //for (int i = 0; i < array4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array4.GetLength(1); j++)
            //    { 
            //        Random  random = new Random(); 
            //        array4[i,j] = random.Next(1,101);

            //        //设置打印坐标让输出的时候元素对齐
            //        Console.SetCursorPosition(4 * j, i);

            //        Console.Write(array4[i, j]);
            //    }
            //     Console.WriteLine();
            //}


            ////求最大元素值
            //int maxElement = 0;
            //for (int i = 0; i < array4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array4.GetLength(1); j++)
            //    {

            //        if (i == 0 && j == 0)
            //        {
            //            maxElement = array4[i, j];
            //        }
            //        else
            //        {
            //            if (array4[i, j] > maxElement)
            //            {
            //                maxElement = array4[i, j];
            //            }
            //        }

            //    }
            //}
            //Console.WriteLine("最大元素值为{0}",maxElement);

            ////求最大值的坐标，可能为多个

            //Console.Write("最大值元素的坐标为：");

            //for (int i = 0; i < array4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array4.GetLength(1); j++)
            //    {
            //        if (array4[i, j] == maxElement)
            //        {
            //            Console.Write("[{0},{1}]  ", i, j);
            //        }
            //    }
            //}


            #endregion

            #region 练习五

            Console.WriteLine("请输入矩阵的行数和列数");
            Console.Write("行数：");
            int rowsNum = int.Parse(Console.ReadLine());
            Console.Write("列数：");
            int columnsNum = int.Parse(Console.ReadLine());

            //生成数列

            Console.WriteLine("生成的矩阵如下：");

            int[,] array5 = new int[rowsNum, columnsNum];

            for (int i = 0; i < array5.GetLength(0); i++)
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    Random random = new Random();
                    array5[i, j] = random.Next(0, 2);

                    //设置打印坐标让输出的时候元素对齐
                    Console.SetCursorPosition(4 * j, 4 + i);

                    Console.Write(array5[i, j]);
                }
                Console.WriteLine();
            }

            //查出所有元素值等于1的索引

            //定义一个用于中转存储的新数组array6，默认所有元素值为0，并把arry5中是1的元素值存入array6中对应的坐标中
            int[,] array6 = new int[rowsNum, columnsNum];

            for (int i = 0; i < array5.GetLength(0); i++)
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    if (array5[i, j] == 1)
                    {
                        for (int k = 0; k < array6.GetLength(0); k++)
                        {
                            for (int m = 0; m < array5.GetLength(1); m++)
                            {
                                if (k == i || m == j)
                                {
                                    array6[k, m] = 1;
                                }
                            }
                        }
                    }
                }
            }

            //打印array6，验证是否 正确

            Console.WriteLine("变换后新矩阵如下：");

            for (int i = 0; i < array6.GetLength(0); i++)
            {
                for (int j = 0; j < array6.GetLength(1); j++)
                {
                    //设置打印坐标让输出的时候元素对齐
                    Console.SetCursorPosition(4 * j, rowsNum + 5 + i);

                    Console.Write(array6[i, j]);
                }
                Console.WriteLine();
            }

            #endregion

        }
    }
}