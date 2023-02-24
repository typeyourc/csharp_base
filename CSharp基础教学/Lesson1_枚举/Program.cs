namespace Lesson1_枚举
{

    //enum E_MonsterType 
    //{
    //    Main,
    //    Other,
    //}

    #region 练习题一相关枚举
    ///// <summary>
    ///// QQ在线状态
    ///// </summary>
    //enum E_QqState
    //{
    //    /// <summary>
    //    /// 在线
    //    /// </summary>
    //    Online,
    //    Offline,
    //    Busy,
    //    Left,
    //    Nodisturb,
    //    Invisibility,
    //}
    #endregion

    #region 练习题二相关枚举
    enum E_CupType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        Tall = 25,
        /// <summary>
        /// 大杯
        /// </summary>
        Grande = 40,
        /// <summary>
        /// 超大杯
        /// </summary>
        Venti = 43,

    }


    /// <summary>
    /// 咖啡杯型
    /// </summary>
    //enum E_CupType
    //{
    //    /// <summary>
    //    /// 中杯
    //    /// </summary>
    //    Tall,
    //    /// <summary>
    //    /// 大杯
    //    /// </summary>
    //    Grande,
    //    /// <summary>
    //    /// 超大杯
    //    /// </summary>
    //    Venti,

    //}
    #endregion

    #region 练习题三相关枚举
    //enum E_Male 
    //{
    //    Atk = 50,
    //    Defend = 100,
    //}
    //enum E_Female
    //{
    //    Atk = 150,
    //    Defend = 20,
    //}

    //enum E_Warrior
    //{
    //    Atk  = 20,
    //    Defend = 100,
    //    Charge,
    //}
    //enum E_Hunter
    //{
    //    Atk = 120,
    //    Defend = 30,
    //    Feigndeath,
    //}
    //enum E_Mage
    //{
    //    Atk = 200,
    //    Defend = 10,
    //    Arcaneblast,
    //}

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");

            #region 知识点一 基本概念

            #endregion

            #region 知识点二 在哪里申明枚举

            #endregion

            #region 知识点三 枚举的使用
            //E_MonsterType monsterType = E_MonsterType.Main;

            //switch (monsterType)
            //{
            //    case E_MonsterType.Main:
            //        break;
            //    case E_MonsterType.other:
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            #region 知识点四 枚举的类型转换

            #endregion

            #region 知识点五 枚举的作用

            #endregion

            #region 练习题一
            //Console.WriteLine("请选择你QQ的状态");
            //Console.WriteLine("0-在线");
            //Console.WriteLine("1-离线");
            //Console.WriteLine("2-忙碌");
            //Console.WriteLine("3-离开");
            //Console.WriteLine("4-请勿打扰");
            //Console.WriteLine("5-隐身");
            //string input = Console.ReadLine();

            //E_QqState usrState = (E_QqState)Enum.Parse(typeof(E_QqState), input);

            //Console.WriteLine(usrState);

            #endregion

            #region 练习题二
            Console.WriteLine("请选择你要购买的咖啡杯型");
            Console.WriteLine("0-中杯");
            Console.WriteLine("1-大杯");
            Console.WriteLine("2-超大杯");

            int input = int.Parse(Console.ReadLine());

            E_CupType inputType = (E_CupType)input;

            switch (inputType)
            {
                case E_CupType.Tall:
                    Console.WriteLine("你购买了中杯咖啡，花费了35元");
                    break;
                case E_CupType.Grande:
                    Console.WriteLine("你购买了大杯咖啡，花费了40元");
                    break;
                case E_CupType.Venti:
                    Console.WriteLine("你购买了超大杯咖啡，花费了43元");
                    break;
                default:
                    Console.WriteLine("请输入正确的杯型");
                    break;
            }


            //string input = Console.ReadLine();

            ////E_CupType cupType = E_CupType.Tall;

            //switch (input)
            //{
            //    case "1":
            //        Console.WriteLine("你购买了中杯咖啡，花费了" + (int)E_CupType.Tall + "元");
            //        break;
            //    case "2":
            //        Console.WriteLine("你购买了大杯咖啡，花费了" + (int)E_CupType.Grande + "元");
            //        break;
            //    case "3":
            //        Console.WriteLine("你购买了超大杯咖啡，花费了" + (int)E_CupType.Venti + "元");
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            #region 练习题三
            //Console.WriteLine("请选择英雄性别与英雄职业");
            //Console.WriteLine("请选择英雄性别");
            //Console.WriteLine("1-男，2-女");
            //String sexInput = Console.ReadLine();
            //Console.WriteLine("请选择英雄职业");
            //Console.WriteLine("1-战士，2-猎人，3-法师");
            //String professionInput = Console.ReadLine();

            //switch (sexInput)
            //{
            //    case "1":
            //        switch (professionInput)
            //        {
            //            case "1":
            //                Console.WriteLine("你选择了\"男性战士\"，" +
            //                    "攻击力：" + ((int)E_Male.Atk + (int)E_Warrior.Atk) + "，" +
            //                    "防御力为：" + ((int)E_Male.Defend + (int)E_Warrior.Defend) + "，" +
            //                    "职业技能：" + E_Warrior.Charge);
            //                break;
            //            case "2":
            //                Console.WriteLine("你选择了\"男性猎人\"，" +
            //                    "攻击力：" + ((int)E_Male.Atk + (int)E_Hunter.Atk) + "，" +
            //                    "防御力为：" + ((int)E_Male.Defend + (int)E_Hunter.Defend) + "，" +
            //                    "职业技能：" + E_Hunter.Feigndeath);
            //                break;
            //            case "3":
            //                Console.WriteLine("你选择了\"男性法师\"，" +
            //               "攻击力：" + ((int)E_Male.Atk + (int)E_Mage.Atk) + "，" +
            //               "防御力为：" + ((int)E_Male.Defend + (int)E_Mage.Defend) + "，" +
            //               "职业技能：" + E_Mage.Arcaneblast);
            //                break;
            //        }
            //        break;
            //    case "2":
            //        switch (professionInput)
            //        {
            //            case "1":
            //                Console.WriteLine("你选择了\"女性战士\"，" +
            //                    "攻击力：" + ((int)E_Female.Atk + (int)E_Warrior.Atk) + "，" +
            //                    "防御力为：" + ((int)E_Female.Defend + (int)E_Warrior.Defend) + "，" +
            //                    "职业技能：" + E_Warrior.Charge);
            //                break;
            //            case "2":
            //                Console.WriteLine("你选择了\"女性猎人\"，" +
            //                    "攻击力：" + ((int)E_Female.Atk + (int)E_Hunter.Atk) + "，" +
            //                    "防御力为：" + ((int)E_Female.Defend + (int)E_Hunter.Defend) + "，" +
            //                    "职业技能：" + E_Hunter.Feigndeath);
            //                break;
            //            case "3":
            //                Console.WriteLine("你选择了\"女性法师\"，" +
            //               "攻击力：" + ((int)E_Female.Atk + (int)E_Mage.Atk) + "，" +
            //               "防御力为：" + ((int)E_Female.Defend + (int)E_Mage.Defend) + "，" +
            //               "职业技能：" + E_Mage.Arcaneblast);
            //                break;
            //        }
            //        break;
            //}


            #endregion
        }
    }
}