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
        magician = 4
    }


    internal class Profile
    {
        public void PlayerStats()
        {
            Console.WriteLine($"Lv. {Player.Level}");
            Console.WriteLine($"Chad ({Player.Name})");
            Console.WriteLine($"공격력 : {Player.basePower}");
            Console.WriteLine($"방어력 : {Player.baseArmor}");
            Console.WriteLine($"체 력 : {Player.CurrentHP}");
            Console.WriteLine($"Gold :  {Player.Gold} G");
        }
    }

    public class PlayerInfo
    {
        public string Name;
        public ClassType Job;
        public int Level { get; set; } = 1;
        public int basePower { get; set; } = 10;
        public int Power { get; set; } = 0;
        public int baseArmor { get; set; } = 5;
        public int Armor { get; set; } = 0;
        public int CurrentHP;
        public int MaxHp { get; set; } = 100;
        public int Gold { get; set; } = 1500;

        public PlayerInfo(string name, ClassType job)
        {
            Name = name;
            Job = job;
            CurrentHP = MaxHp;
        }
    }
}