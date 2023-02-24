using System.Globalization;
using System.Reflection;

namespace Lesson2_一维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组");

            #region 练习1
            //int[] array = new int[100];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //    //Console.Write("array[{0}]={1}  ", i, array[i]);
            //    //if (i % 5 == 0)
            //    //{
            //    //    Console.Write("\n");
            //    //}
            //}

            #endregion

            #region 练习2

            //int[] array2 = new int[100];
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = array[i] * 2;
            //    Console.WriteLine(array2[i]);
            //}

            #endregion

            #region 练习3

            //Random random = new Random();

            //int[] array3 = new int[10];
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    int r = random.Next(0, 101);
            //    array3[i] = r;
            //    Console.WriteLine("r={0},array3[{1}]={2}", r, i, r);
            //}

            #endregion

            #region 练习4

            //生成随机整数数组
            //Random random = new Random();

            //int[] array4 = new int[11];

            //for (int i = 0; i < array4.Length; i++)
            //{
            //    int r = random.Next(0,101);
            //    array4[i] = r;
            //    Console.Write("array4[{0}]={1}   ",i,array4[i]);
            //    if (i % 4 == 0)
            //    {
            //        Console.Write("\n");
            //    }
            //}
            //Console.WriteLine("\n-------------------------");

            ////求数组中的最大值
            //int maxNum = array4[0];
            //for (int i = 0; i < array4.Length - 1; i++)
            //{
            //    if (array4[i] > maxNum)
            //    {
            //        maxNum = array4[i];
            //    }
            //}

            //int j = 0;
            //for (int i = 0; i < array4.Length; i++)
            //{
            //    if (array4[i]==maxNum)
            //    {
            //        Console.WriteLine("最大值的索引为{0}",i);
            //        j++;
            //    }
            //}
            //Console.WriteLine("一共有{0}个值最大",j);
            //Console.WriteLine("最大值为{0}",maxNum);
            //Console.WriteLine("-------------------------");

            ////求数组中的最小值

            //int minNum = array4[0];
            //for (int i = 0; i < array4.Length - 1; i++)
            //{
            //    if (array4[i] < minNum)
            //    {
            //        minNum = array4[i];
            //    }
            //}

            //j = 0;
            //for (int i = 0; i < array4.Length; i++)
            //{
            //    if (array4[i] == minNum)
            //    {
            //        Console.WriteLine("最小值的索引为{0}", i);
            //        j++;
            //    }
            //}
            //Console.WriteLine("一共有{0}个数据最小", j);
            //Console.WriteLine("最小值为{0}", minNum);
            //Console.WriteLine("-------------------------");

            ////求数组元素之和

            //int sum = 0;
            //for (int i = 0; i < array4.Length; i++)
            //{
            //    sum += array4[i];
            //}
            //Console.WriteLine("数组元素之和为{0}", sum);
            //Console.WriteLine("-------------------------");

            ////求数组元素平均值
            //Console.WriteLine("数组元素的平均值为{0}",1.0f*sum/array4.Length);


            #endregion

            #region 练习5

            //交换第一个和最后一个，依次类推，当前只考虑数组元素个数是偶数的情况，验证了一下这个算法对于奇数也可以
            //int temp = 0;

            //for (int i = 0; i < array4.Length/2; i++)
            //{
            //    temp = array4[i];
            //    array4[i] = array4[array4.Length - 1 - i];
            //    array4[array4.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < array4.Length; i++)
            //{

            //    Console.Write("array4[{0}]={1}  ", i, array4[i]);
            //    if (i % 4 == 0)
            //    { 
            //    Console.Write('\n');
            //    }
            //}

            #endregion

            #region 练习6

            //生成随机整数元素数组
            //Random random = new Random();

            //int[] array6 = new int[10];

            //for (int i = 0; i < array6.Length; i++)
            //{
            //    int r = random.Next(-100, 101);
            //    array6[i] = r;
            //    Console.Write("array4[{0}]={1}   ", i, array6[i]);
            //    if (i % 4 == 0)
            //    {
            //        Console.Write("\n");
            //    }
            //}
            //Console.WriteLine("\n-------------------------");

            //for (int i = 0; i < array6.Length; i++)
            //{
            //    if (array6[i] >0)
            //    {
            //        array6[i]++;
            //    }
            //    else if (array6[i] < 0)
            //    {
            //        array6[i]--;
            //    }
            //    Console.Write("array4[{0}]={1}   ", i, array6[i]);
            //    if (i % 4 == 0)
            //    {
            //        Console.Write("\n");
            //    }
            //}


            #endregion

            #region 练习7

            ////输入成绩
            //int[] mathScore = new int[10];
            //for (int a = 0; a < mathScore.Length; a++)
            //{
            //    Console.Write("第{0}位同学，请输入你的成绩：", a + 1);
            //    mathScore[a] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("---------------------------------------------");

            //Console.WriteLine("10个同学的成绩分别如下：");
            //for (int a = 0;a < mathScore.Length; a++)
            //{
            //    Console.Write("{0}  ", mathScore[a]);
            //    if ((a + 1) % 5 == 0)
            //    {
            //        Console.Write("\n");
            //    }
            //}

            ////最高分,最低分
            //int maxScore = mathScore[0];
            //int minScore = mathScore[0];

            //for (int i = 0; i < mathScore.Length - 1; i++)
            //{
            //    if (mathScore[i + 1] > maxScore)
            //    {
            //        maxScore = mathScore[i + 1];
            //    }
            //    if (mathScore[i + 1] < minScore)
            //    {
            //        minScore = mathScore[i + 1];
            //    }
            //}

            //Console.WriteLine("最高分是{0}，最低分是{1}",maxScore,minScore);

            //int mathSumScore = 0;
            //for (int i = 0; i < mathScore.Length; i++)
            //{
            //    mathSumScore += mathScore[i];
            //}
            //Console.WriteLine("平均分是{0}",1.0f*mathSumScore/mathScore.Length);

            #endregion

            #region 练习8

            string[] array8 = new string[25];
            //■□存储到字符串类型数组
            for (int i = 0; i < array8.Length; i++)
            {
                if ((i + 1) % 2 == 0) 
                {
                    array8[i] = "□";
                }
                else
                {
                    array8[i] = "■";
                }
            }

            //打印形状
            for (int i = 0; i < array8.Length; i++)
            {
                Console.Write(array8[i]);
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("\n");
                }
            }

            #endregion
        }
    }
}