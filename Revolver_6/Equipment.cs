using static Revolver_6.Data;

namespace Revolver_6
{
    public class WeaponInfo : ItemInfo
    {
        private int Power = 1000;

        public WeaponInfo() { }
        public WeaponInfo(ClassType type, string name, int power, int cost, int index)
        {
            base.Type = type;
            base.Name = name;
            this.Power = power;
            base.Cost = cost;
            base.Eq = false;
            base.Index = index;
        }

        public override void ShowItem()
        {
            Helper.Typing("", "분류 : ", "blue", $"{Type}", 0);
            Helper.TypingWrite("", $"이름 : {Name}", 0);
            if (Eq == true)
            {
                Helper.TypingWrite("red", "[E]", 0);
            }
            Helper.TypingWrite("", " 공격력 : ", 0);
            Helper.TypingWrite("magenta", Power, 0);
            Helper.Typing("", $" 가격 : ", "yellow", Cost, 0);
            Console.WriteLine();

        }

        public override void EqItem() // 장비 장착/해제
        {
            if (Eq == false)
            {
                Data.Player.Power += Power;
                Helper.Typing("green", Name, "", "을 장착 했습니다.");
                Eq = true;
                Console.WriteLine();
            }
            else if (Eq == true)
            {
                Data.Player.Power -= Power;
                Helper.Typing("green", Name, "", "을 해제 했습니다.");
                Eq = false;
                Console.WriteLine();
            }

            GameManager.Instance.title.GameInventory();
        }
    }
    public class ProtecterInfo : ItemInfo
    {
        public int HP = 1000;
        public int Armor = 1000;
        public ProtecterInfo() { }

        public ProtecterInfo(ClassType type, string name, int hP, int armor, int cost, int index)
        {
            base.Type = type;
            base.Name = name;
            this.HP = hP;
            this.Armor = armor;
            base.Cost = cost;
            base.Eq = false;
            base.Index = index;
        }
        public override void ShowItem()
        {
            Helper.Typing("", "분류 : ", "blue", $"{Type}", 0);
            Helper.TypingWrite("", $"이름 : {Name}", 0);
            if (Eq == true)
            {
                Helper.TypingWrite("red", "[E]", 0);
            }
            Helper.TypingWrite("", " 체력 : ", 0);
            Helper.TypingWrite("magenta", HP, 0);
            Helper.TypingWrite("", " 방어력 : ", 0);
            Helper.TypingWrite("magenta", Armor, 0);
            Helper.Typing("", $" 가격 : ", "yellow", Cost, 0);
            Console.WriteLine();
        }

        public override void EqItem() // 장비 장착/해제
        {
            if (Eq == false)
            {
                Data.Player.MaxHp += HP;
                Data.Player.CurrentHP += HP;
                Data.Player.Armor += Armor;
                Helper.Typing("green", Name, "", "을 장착 했습니다.");
                Eq = true;
                Console.WriteLine();
            }
            else if (Eq == true)
            {
                Data.Player.MaxHp -= HP;
                Data.Player.CurrentHP -= HP;
                Data.Player.Armor -= Armor;
                Helper.Typing("green", Name, "", "을 해제 했습니다.");
                Eq = false;
                Console.WriteLine();
            }

            GameManager.Instance.title.GameInventory();
        }
    }
}

