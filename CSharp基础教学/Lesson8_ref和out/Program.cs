using System;

namespace Lesson8_ref和out
{
    internal class Program
    {
        //场景一
        static void ChangeNum(int a)
        {
            a = 300;
        }

        //场景二
        static void ChangeArr(int[] a)
        {
           //int[] a = { 1, 2, 3, 4, 5, 6, 7 };//错误写法，内部不用再申明传参
             a[0] = 77;
        }

        //场景三
        static void ChangeArrNew(int[] a)
        {
            a = new int[] { 9, 10, 11 };
        }

        //练习二
        //static string[] UserInfo(string name, string pwd)
        //{

        //    //默认返回
        //    string[] arrEx = new string[] { "1", "登录成功" };

        //    if (name != "admin")
        //    {
        //        arrEx[0] = "0";
        //        arrEx[1] = "用户名错误";
        //    }
        //    else
        //    {
        //        arrEx[0] = "0";
        //        arrEx[1] = "密码错误";
        //    }

        //    return arrEx;
        //}

        static void UserInfo(string name, string pwd, out bool resultLogIn, out string infoLogIn)
        {
            if (name != "admin")
            {
                resultLogIn = false;
                infoLogIn = "用户名错误";
            }
            else if (name == "admin" && pwd != "888")
            {
                resultLogIn = false;
                infoLogIn = "密码错误";
            }
            else
            {
                resultLogIn = true;
                infoLogIn = "登录成功";
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("ref和out");

            //场景一
            //int b = 500;
            //ChangeNum(b);
            //Console.WriteLine("场景一");
            //Console.WriteLine(b);
            //Console.WriteLine();

            ////场景二
            //int[] arr2 = { 1, 2, 3 };
            //Console.WriteLine("场景二");
            //ChangeArr(arr2);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine();

            ////场景三
            //int[] arr3 = { 1, 2, 3 };
            //Console.WriteLine("场景三");
            //ChangeArrNew(arr3);
            //Console.WriteLine(arr3[0]);
            //Console.WriteLine();


            //练习题二、
            bool resultLogIn;
            string infoLogIn;
            Console.Write("请输入用户名：");
            string name = Console.ReadLine();
            Console.Write("请输入密码：");
            string pwd = Console.ReadLine();
            UserInfo(name, pwd, out resultLogIn, out infoLogIn);
            Console.WriteLine(resultLogIn + "  " + infoLogIn);
        }
    }
}