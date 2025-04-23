using static Revolver_6.Data;

namespace Revolver_6
{
    internal class Equipment
    {
        public class WeaponInfo : Item.ItemInfo
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
        }
    }   
}