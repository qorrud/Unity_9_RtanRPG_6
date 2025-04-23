namespace Revolver_6
{
    public class ItemInfo
    {
        protected ClassType Type;
        protected string Name;
        protected int Cost;
        protected bool Eq;
        public ItemInfo()
        {
            Type = ClassType.knight;
            Name = "공백";
            Cost = -1;
            Eq = false;
        }
        public ItemInfo(ClassType type, string name, int cost)
        {
            Type = type;
            Name = name;
            Cost = cost;
            Eq = false;
        }
        public virtual void ShowItem()
        {
            
        }
    }

    public static class ItemDB
    {
        public static Dictionary<int, ItemInfo> Items = new Dictionary<int, ItemInfo>()
        {
            {1, new WeaponInfo(ClassType.knight, "기본검", 15, 200)},
            {101, new ProtecterInfo(ClassType.knight, "천갑옷", 50, 5, 200)},
        };
    }
}