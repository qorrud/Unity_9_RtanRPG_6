namespace Revolver_6
{
    internal class Item
    {
        public class ItemInfo
        {
            public ClassType Type;
            public string Name;
            public int Cost;
            public bool Eq;
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
        }

        public static class ItemDB
        {
            public static Dictionary<int, ItemInfo> Items = new Dictionary<int, ItemInfo>() 
            {   
                {1, new Equipment.WeaponInfo(ClassType.knight, "기본검", 15, 200)},
            };
        }
    }
}