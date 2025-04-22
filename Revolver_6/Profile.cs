using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using static Revolver_6.Data;
using static Revolver_6.Helper;

namespace Revolver_6
{

    public enum ClassType
    {
        none = 0,
        knight = 1,
        archer = 2,
        rogue = 3,
        magician = 4,
    }


    internal class Profile
    {
        public static void PlayerStats()
        {
            Console.WriteLine($"Lv. {Player.Level}");
            Console.WriteLine($"Chad ({Player.Name})");
            Console.WriteLine($"공격력 : {Player.Power}");
            Console.WriteLine($"방어력 : {Player.Armor}");
            Console.WriteLine($"체 력 : {Player.CurrentHP}");
            Console.WriteLine($"Gold :  {Player.Gold} G");
        }
    }

    public class PlayerInfo
    {
        public string Name = "기본";
        public ClassType Job = ClassType.archer;
        public int Level { get; set; } = 1;
        public int Power { get; set; } = 0;
        public int Armor { get; set; } = 0;
        public int CurrentHP = 1;
        public int MaxHp { get; set; } = 100;
        public int Gold { get; set; } = 1500;

        public PlayerInfo(string name, ClassType job)
        {
            Name = name;
            Job = job;

            switch (job)
            {
                case ClassType.knight:
                    MaxHp = 150;
                    break;

                case ClassType.archer:
                    break;

                case ClassType.rogue:
                    break;

                case ClassType.magician:
                    break;

            }


            CurrentHP = MaxHp;

        }
    }
}