namespace Revolver_6
{
    public class ItemInfo
    {
        public ClassType Type { get; protected set; } // 무기를 쓸 수 있는 직업
        public string Name { get; protected set; } 
        public int Cost { get; protected set; }
        public bool Eq { get; protected set; }
        public ItemInfo()
        {
            Type = ClassType.knight;
            Name = "오류!";
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
        public virtual void ShowItem(int key)
        {
            Helper.Typing("green", ItemDB.Items[key].Type);
            Helper.Typing("green", ItemDB.Items[key].Name);
            Helper.Typing("green", ItemDB.Items[key].Cost);
        }
    }

    public static class ItemDB
    {
        public static Dictionary<int, ItemInfo> Items = new Dictionary<int, ItemInfo>()
        {
            {1, new WeaponInfo(ClassType.knight, "기본검", 15, 200)},
            {101, new ProtecterInfo(ClassType.knight, "천갑옷", 50, 5, 200)},
            {201, new ItemInfo(ClassType.all, "체력포션", 200)}
        };
    }
}