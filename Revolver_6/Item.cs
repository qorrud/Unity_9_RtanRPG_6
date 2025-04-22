namespace Revolver_6
{
    internal class Item
    {
        public enum ItemType
        {
            Weapon, Armor, Potion
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
                Index = -1;
                Eq = false;
            }
            public ItemInfo(ItemType type, string name, int cost, int index, bool eq)
            {
                Type = type;
                Name = name;
                Cost = cost;
                Index = index;
                Eq = eq;
            }
        }
    }
}