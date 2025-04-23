using static Revolver_6.Data;

namespace Revolver_6
{
    public class WeaponInfo : ItemInfo
    {
        public int Power = 1000;

        public WeaponInfo(ClassType type, string name, int power, int cost)
        {
            base.Type = type;
            base.Name = name;
            this.Power = power;
            base.Cost = cost;
            base.Eq = false;
        }

        public override void ShowItem()
        {

        }
    }
    public class ProtecterInfo : ItemInfo
    {
        public int HP = 1000;
        public int Armor = 1000;

        public ProtecterInfo(ClassType type, string name, int hP, int armor, int cost)
        {
            base.Type = type;
            base.Name = name;
            this.HP = hP;
            this.Armor = armor;
            base.Cost = cost;
            base.Eq = false;
        }
        public override void ShowItem()
        {

        }
    }
}
