namespace Revolver_6
{
    public class ItemInfo
    {
        public ClassType Type { get; protected set; } // 무기를 쓸 수 있는 직업
        public string Name { get; protected set; }
        public int Cost { get; protected set; }
        public bool Eq { get; protected set; }
        public int Index { get; protected set; }
        public ItemInfo()
        {
            Type = ClassType.knight;
            Name = "오류!";
            Cost = -1;
            Eq = false;
            Index = -1;
        }
        public ItemInfo(ClassType type, string name, int cost, int index)
        {
            Type = type;
            Name = name;
            Cost = cost;
            Eq = false;
            Index = index;
        }
        public virtual void ShowItem()
        {
            Helper.Typing("", "분류 : ", "blue", "범용", 0);
            Helper.Typing("", $"이름 : {Name} 가격 : ", "yellow", Cost, 0);
        }

        public virtual void EqItem() // 장비 장착
        {
            Helper.Typing("", "장착 할 수 없는 아이템입니다.");
            GameManager.Instance.title.GameInventory();
        }
    }

    public static class ItemDB
    {
        public static Dictionary<int, ItemInfo> Items = new Dictionary<int, ItemInfo>()
        {
            {1, new WeaponInfo(ClassType.knight, "기본_검", 15, 200, 1)},
            {2, new WeaponInfo(ClassType.archer, "기본_활", 15, 200, 2)},
            {3, new WeaponInfo(ClassType.rogue, "기본_단검", 15, 200, 3)},
            {4, new WeaponInfo(ClassType.magician, "기본_지팡이", 15, 200, 4)},

            {101, new ProtecterInfo(ClassType.knight, "천갑옷", 50, 5, 200, 101)},
            {102, new ProtecterInfo(ClassType.archer, "천후드", 50, 5, 200, 102)},
            {103, new ProtecterInfo(ClassType.rogue, "천망토", 50, 5, 200, 103)},
            {104, new ProtecterInfo(ClassType.magician, "천로브", 50, 5, 200, 104)},

            {201, new ItemInfo(ClassType.all, "체력포션", 200, 201)},
            {202, new ItemInfo(ClassType.all, "마나포션", 200, 202)},
            {203, new ItemInfo(ClassType.all, "분노의_영약", 200, 203)},
            {204, new ItemInfo(ClassType.all, "경험치_포션", 200, 204)},
            {205, new ItemInfo(ClassType.all, "분노의_영약", 200, 205)},

            {666, new WeaponInfo(ClassType.all, "테스트_무기", 1000, 200, 666)},
            {667, new ProtecterInfo(ClassType.all, "테스트_방어구", 1000, 1000, 200, 667)},
        };
    }
}