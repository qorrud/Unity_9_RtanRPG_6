namespace Revolver_6
{
    internal class Item
    {
        public enum ItemType
        {
            None = 0,
            Weapon = 1,
            Armor = 2,
            Potion = 4,
        }

        public class ItemInfo
        {
            public ItemType Type;
            public string Name;
            public int Cost;
            public int Index;
            public bool Eq;
            public ItemInfo()
            {
                Type = ItemType.Weapon;
                Name = "공백";
                Cost = -1;
                Eq = false;
            }
            public ItemInfo(ItemType type, string name, int cost)
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
                {1, new ItemInfo(ItemType.Weapon, "임시", 100)}
            };
        }

        public void AddItem()
        {
            
        }
    }
}