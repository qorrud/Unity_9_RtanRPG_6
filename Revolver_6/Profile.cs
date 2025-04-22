using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Revolver_6
{

    enum ClassType
    {
        none = 0,
        knight = 1,
        archer = 2,
        rogue = 3,
        magician = 4
    }


    internal class Profile
    {
        public void NewStats() // 플레이어 객체를을 초기화 하는 함수
        {
            PlayerStats stats = new PlayerStats();
        }
        public void Player()
        {
            Console.WriteLine($"Lv. {stats.Level}");
            Console.WriteLine($"Chad ({stats.Level})");
            Console.WriteLine($"공격력 : {stats.basePower}");
            Console.WriteLine($"방어력 : {stats.baseArmor}");
            Console.WriteLine($"체 력 : {stats.CurrentHP} / {stats.MaxHp}");
            Console.WriteLine($"Gold :  {stats.Gold} G");
        }
    }

    public class PlayerStats
    {
        public int Level { get; set; } = 1;
        public int basePower { get; set; } = 10;
        public int Power { get; set; } = 0;
        public int baseArmor { get; set; } = 5;
        public int Armor { get; set; } = 0;
        public int CurrentHP { get; set; } = 100;
        public int MaxHp { get; set; } = 100;
        public int Gold { get; set; } = 1500;

        public string Name;
        public ClassType Job;

        public PlayerStats(string name, ClassType job)
        {
            Name = name;
            Job = job;

        }
    }
}