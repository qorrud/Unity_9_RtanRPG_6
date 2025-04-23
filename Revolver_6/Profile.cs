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

    public class JobInfo
    {
        public static void Jobinfo()
        {
            Helper.Typing("", "[1]", "yellow", $"\t'[Knight]', 공격력은 약하지만 방어력과 체력이 높은 직업");
            Helper.Typing("", "[2]", "green", $"\t'[Archer]', 공격력은 높지만 방어력과 체력이 낮은 직업");
            Helper.Typing("", "[3]", "red", $"\t'[Rogue]', 공격력과 체력이 높지만 방어력이 낮고 돈이 많은 직업");
            Helper.Typing("", "[4]", "bule", $"\t'[Magician]', 공격력이 매우 높지만 방어력과 체력이 매우 낮은 직업");
        }
    }

    internal class Profile
    {
        public static void PlayerStats()
        {
            Helper.Typing("", $"\nLv. {Player.Level}", 0);
            Helper.Typing("", $"Chad ({Player.Name})", 0);
            Helper.Typing("", $"공격력 : {Player.Power}", 0);
            Helper.Typing("", $"방어력 : {Player.Armor}", 0);
            Helper.Typing("", $"체 력 : {Player.CurrentHP}", 0);
            Helper.Typing("", $"Gold :  {Player.Gold} G", 0);
        }
    }

    public class PlayerInfo
    {
        public string Name = "기본";
        public ClassType Job = ClassType.knight;
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
                    Power = 10;
                    Armor = 10;
                    MaxHp = 150;
                    Gold = 1500;
                    break;

                case ClassType.archer:
                    Power = 20;
                    Armor = 5;
                    MaxHp = 75;
                    Gold = 1500;
                    break;

                case ClassType.rogue:
                    Power = 15;
                    Armor = 5;
                    MaxHp = 125;
                    Gold = 3000;
                    break;

                case ClassType.magician:
                    Power = 30;
                    Armor = 0;
                    MaxHp = 50;
                    Gold = 1500;
                    break;

            }


            CurrentHP = MaxHp;

        }
    }
}