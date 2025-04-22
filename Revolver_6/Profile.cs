using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Revolver_6
{

    public enum ClassType
    {
        none = 0,
        knight = 1,
        archer = 2,
        rogue = 3,
        magician = 4
    }


    internal class Profile
    {
        PlayerStats stats = new PlayerStats();
        public void Player()
        {
            Console.WriteLine($"Lv. {stats.Level}");
            Console.WriteLine($"Chad ({stats.Level})");
            Console.WriteLine($"공격력 : {stats.basePower}");
            Console.WriteLine($"방어력 : {stats.baseArmor}");
            Console.WriteLine($"체 력 : {stats.CurrentHP} / {stats.MaxHp}");
            Console.WriteLine($"Gold :  {stats.Gold} G");
        }

        public void JobText()
        {
            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("1. 기사");
            Console.WriteLine("2. 아처");
            Console.WriteLine("3. 도적");
            Console.WriteLine("4. 마법사");

            Console.Write(">> 선택 : ");
        }

        public static ClassType JobChoice()
        {
            ClassType Job = ClassType.none;

            int Jobinput = Helper.WhatNum(1, 4);


            switch (Jobinput)
            {
                case 1:
                    Job = ClassType.knight;
                    break;
                case 2:
                    Job = ClassType.archer;
                    break;
                case 3:
                    Job = ClassType.rogue;
                    break;
                case 4:
                    Job = ClassType.magician;
                    break;
            }
            return Job;
        }
    }

    public class PlayerStats
    {
        public int Level { get; set; } = 1;

        public string Name { get; set; }

        public ClassType Job { get; set; }

        public int basePower { get; set; } = 10;
        public int Power { get; set; } = 0;
        public int baseArmor { get; set; } = 5;
        public int Armor { get; set; } = 0;
        public int CurrentHP { get; set; } = 100;
        public int MaxHp { get; set; } = 100;
        public int Gold { get; set; } = 1500;

    }
}