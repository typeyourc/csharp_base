using System.Diagnostics.Metrics;
using System.Threading;

namespace Lesson12_结构体练习
{
    //练习一：用结构体描述学员信息，姓名、性别、年龄、班级、专业，创建两个学员初始化并打印
    struct StuInfo
    {
        public string name;
        public bool sex;
        public int age;
        public string classs;
        public string major;

        public StuInfo(string name, bool sex, int age, string classs, string major) 
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.classs = classs;
            this.major = major;
        }
    }

    //练习二：private和public两个区别，用了public可以在程序内调用结构体内变量、参数，没用public或者用了private则不可调用

    //练习三：用结构体描述矩形长、宽，创建1个矩形并初始化，打印矩形长、宽、面积、周长等信息
    struct Rectangle
    {
        public int length;
        public int width;

        public int Area(int length, int width)
        {
            return length * width;
        }

        public int Perimeter(int length, int width)
        {
            return 2 * (length + width);
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
    }
    //练习四：结构体描述玩家信息，名字、职业，让用户输入名字，选择职业，打印玩家攻击信息：猎人 唐老师 释放了 假死 技能
   //方法一：
    //struct Player
    //{
    //    public string name;
    //    public string occupation;
    //    //public string[,]occupation = new string[,] { { "战士", "冲锋" }, 
    //    //                                             { "猎人", "假死" }, 
    //    //                                             { "法师", "奥术冲击" } };  
        
    //    public Player(string name, string occupation)
    //    {
    //        this.name = name;
    //        this.occupation = occupation;
    //    }
    //}

    //方法二：
    struct Player
    {
        public string name;
        public E_occupation occupation;
    }
    /// <summary>
    /// 玩家职业
    /// </summary>
    enum E_occupation
    {
        /// <summary>
        /// 战士
        /// </summary>
        Warrior,
        /// <summary>
        /// 猎人
        /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Mage
    }

    //练习五：使用结构体描述小怪兽

    struct Monster
    {
        public string name;
        public int hp;
        public int atk;

        public Monster(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }

    }

    //练习六：实现奥特曼打小怪兽，结构体描述奥特曼和小怪兽，定义两个方法，分别是奥特曼攻击小怪兽，和小怪兽攻击奥特曼

    struct Ultraman
    {
        public string name;
        public int hp;
        public int atk;

        public Ultraman(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }
    }

    internal class Program
    {

        //练习四：方法一的枚举
        //enum E_occupation
        //{
        //    Warrior,
        //    Hunter,
        //    Mage
        //}

        //练习六的函数
        //奥特曼攻击小怪兽

        static void UltraBeatMons(Ultraman u, Monster m)
        {
            Console.WriteLine("奥特曼{0}对怪兽{1}造成{2}点攻击", u.name, m.name, u.atk);
            Console.WriteLine("怪兽{0}剩余血量{1}", m.name, m.hp - u.atk);
        }

        //小怪兽攻击奥特曼
        static void MonsBeatUltra(Monster m, Ultraman u)
        {
            Console.WriteLine("怪兽对奥特曼造成{0}点攻击", m.atk);
            Console.WriteLine("奥特曼剩余血量{0}", u.hp - m.atk);
        }


        static void Main(string[] args)
        {
            //练习一
            //StuInfo s1 = new StuInfo("王大锤", true, 22, "大一", "物理");
            //StuInfo s2 = new StuInfo("唐唐", false, 32, "大二", "化学");

            //Console.WriteLine(s1.name + "  " + s1.sex + "  " + s1.age + "  " + s1.classs + "  " + s1.major);
            //Console.WriteLine(s2.name + "  " + s2.sex + "  " + s2.age + "  " + s2.classs + "  " + s2.major);

            //练习三
            //Rectangle r1 = new Rectangle(6, 8);
            //Console.WriteLine(r1.length + "  " + r1.width + "  " + r1.Area(6, 8) + "  " + r1.Perimeter(6, 8));

            //练习四

            //方法一：
            //string[,] occupation = new string[,] { { "战士", "冲锋" },
            //                                       { "猎人", "假死" },
            //                                       { "法师", "奥术冲击" } };
            //string name;
            //Console.WriteLine("请输入玩家姓名：");
            //name = Console.ReadLine();
            //Console.WriteLine("请选择职业，0-战士，1-猎人，2-法师");
            //int choose = int.Parse(Console.ReadLine());
            //E_occupation echoose = (E_occupation)choose;//注意这里枚举类型的定义以及将int强制转换成枚举，注意跟下面switch的结合使用

            //Player p1;

            //switch (echoose)
            //{
            //    case E_occupation.Warrior:
            //        p1 = new Player(name, occupation[0, 0]);
            //        Console.WriteLine(p1.occupation + p1.name + "释放了" + occupation[0, 1]);

            //        break;

            //    case E_occupation.Hunter:
            //        p1 = new Player(name, occupation[1, 0]);
            //        Console.WriteLine(p1.occupation + p1.name + "释放了" + occupation[1, 1]);
            //        break;

            //    case E_occupation.Mage:
            //        p1 = new Player(name, occupation[2, 0]);
            //        Console.WriteLine(p1.occupation + p1.name + "释放了" + occupation[2, 1]);
            //        break;
            //}

            //练习五

            //练习六(感觉用结构体有点多此一举，目前没感受到其作用是什么，如何自动初始化多个结构体)
            ////1定义数组
            //int[] arr = new int[10];

            ////2初始化数组
            //Random rand = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //        arr[i] = rand.Next(1, 11);
            //}

            ////3初始化怪兽并打印
            //for (int i = 0; i < arr.Length; i++)
            //{              
            //    Monster monster = new Monster(i.ToString(), arr[i]);             
            //    Console.WriteLine("小怪兽{0},攻击力为{1}", monster.name, monster.atk);
            //}

            //练习七
            //初始化一个奥特曼和小怪兽
            Random random = new Random();
            Ultraman u = new Ultraman("欧文", 100, random.Next(1,11));
            Monster m = new Monster("哥斯拉", 100, random.Next(1,5));

            UltraBeatMons(u, m);

            Console.WriteLine("————————————————————————————————");

            MonsBeatUltra(m, u);
        }
    }
}