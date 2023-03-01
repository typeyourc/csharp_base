namespace Lesson12_结构体
{
    struct Student
    {
        //变量
        public int age;
        public bool sex;
        public int number;
        public string name;

        //构造函数
        public Student(int age, bool sex, int number, string name)
        {
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = "";
        }

        //构造函数补充知识，构造函数可以重载
        public Student(int age)
        {
            this.age=age;
            sex=false;
            this.number = 0;
            this.name = "123";
        }

        //函数
        public void Speak()
        {
            Console.WriteLine("我的名字是{0},我今年{1}岁", name, age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("结构体");

            //Student s1;
            //s1.age = 1;
            //s1.sex = true;
            //s1.number = 1;
            //s1.name = "唐老师";
            //s1.Speak();
        }
    }
}