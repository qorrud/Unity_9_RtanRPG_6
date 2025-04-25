using static Revolver_6.Data;

namespace Revolver_6
{
    public class WeaponInfo : ItemInfo
    {
        public int Power = 1000;

        public WeaponInfo() { }
        public WeaponInfo(ClassType type, string name, int power, int cost)
        {
            base.Type = type;
            base.Name = name;
            this.Power = power;
            base.Cost = cost;
            base.Eq = false;
        }

        public override void ShowItem(int key)
        {
            if (ItemDB.Items[key] is WeaponInfo weaponInfo)
            {
                Helper.Typing("green", weaponInfo.Type);
                Helper.Typing("green", weaponInfo.Name);
                if (Eq == true)
                {
                    Helper.Typing("red", "[E]");
                }
                Helper.Typing("green", weaponInfo.Power);
                Helper.Typing("green", weaponInfo.Cost);
            }
            else
            {
                new WeaponInfo();
            }
        }
    }
    public class ProtecterInfo : ItemInfo
    {
        public int HP = 1000;
        public int Armor = 1000;
        public ProtecterInfo() { }

        public ProtecterInfo(ClassType type, string name, int hP, int armor, int cost)
        {
            base.Type = type;
            base.Name = name;
            this.HP = hP;
            this.Armor = armor;
            base.Cost = cost;
            base.Eq = false;
        }
        public override void ShowItem(int key)
        {

            if (ItemDB.Items[key] is ProtecterInfo protecter)
            {
                Helper.Typing("green", protecter.Type);
                Helper.Typing("green", protecter.Name);
                if (Eq == true)
                {
                    Helper.Typing("red", "[E]");
                }
                Helper.Typing("green", protecter.HP);
                Helper.Typing("green", protecter.Armor);
                Helper.Typing("green", protecter.Cost);

            }
            else
            {
                new ProtecterInfo();
            }
        }
    }
}
