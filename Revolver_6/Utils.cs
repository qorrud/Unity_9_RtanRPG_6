using System.Security.Cryptography.X509Certificates;
using static Revolver_6.Data;

namespace Revolver_6
{
    internal class ExtraEffect
    {
        public static void UseEffect(string name, int value = 0)
        {
            switch (name)
            {
                case "heal":
                    Player.CurrentHP += value;
                    if (Player.CurrentHP >= Player.MaxHp)
                        Player.CurrentHP = Player.MaxHp;


                    break;

                case "heal%":
                    float healValue = Player.MaxHp * value / 100f;
                    Player.CurrentHP += (int)healValue;
                    if (Player.CurrentHP >= Player.MaxHp)
                    {
                        Player.CurrentHP = Player.MaxHp;
                        Helper.Typing("green", "체력이 ", "", "가득찼다! \n현재 체력 : ", "", Player.CurrentHP);
                    }

                    Helper.Typing("", "현재 체력 : ", "", Player.CurrentHP);
                    Console.ReadLine();
                    break;

                case "":
                    break;

            }
        }
        public static int MonsterValue()
        {
            int sum = 0;
            for (int i = 0; i < Data.monster.Length; i++)
            {
                sum += monster[i].Index;
            }
            return sum;
        }

        public void PlayerExp(int value)
        {
            Data.Player.Exp += value;

            if (Player.Exp >= Player.Level * 30)
            {
                Player.Exp -= Player.Level * 30;
                Player.Level++;
                Helper.Typing("green", "축하합니다!", "blue", $"{Data.Player.Level}", "green", "이 되었습니다!");
            }
        }

        public static void GainExp()
        {
            int sum = 0;
            for (int i = 0; i < Data.monster.Length; i++)
            {
                sum += monster[i].Exp;
            }
            Player.Exp += sum; //이걸 플레이어 프로필에 바로 저장하는게 맞나...?
        }

        public static void GainGold()
        {
            int sum = 0;
            for (int i = 0; i < Data.monster.Length; i++)
            {
                sum += monster[i].Gold;
            }
            Player.Gold += sum; // Data Player에 저장해야하나? 이따 물어보자
        }

        public void BattleReward(int value)
        {
            if (value <= 5)
            {
                ItemManager.AddItem(1); // 기본검 제공
            }
            else if (value <= 10)
            {
                ItemManager.AddItem(101); // 기본방어구 제공
            }
        }

        public static void MakeShop()
        {
            GameManager.Instance.DummyInt1 = new int[3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int a = random.Next(1, 4);
                GameManager.Instance.DummyInt1[i] = a;
            }
            int[] weaponSell = new int[GameManager.Instance.DummyInt1[0]]; 
            int[] protecterSell = new int[GameManager.Instance.DummyInt1[1]]; 
            int[] normalSell = new int[GameManager.Instance.DummyInt1[2]]; 

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < weaponSell.Length; j++)
                        {
                            weaponSell[j] = random.Next(1, 5);
                        }
                        break;

                    case 1:
                        for (int j = 0; j < protecterSell.Length; j++)
                        {
                            protecterSell[j] = random.Next(101, 105);
                        }
                        break;

                    case 2:
                        for (int j = 0; j < normalSell.Length; j++)
                        {
                            normalSell[j] = random.Next(201, 204);
                        }
                        break;
                }
            }
            GameManager.Instance.DummyInt1 = weaponSell;
            GameManager.Instance.DummyInt2 = protecterSell;
            GameManager.Instance.DummyInt3 = normalSell;
        }
    }

    public class ItemManager
    {
        public static void AddItem(int key)
        {
            if (ItemDB.Items[key] is WeaponInfo)
            {
                Data.Inventory.Add(ItemDB.Items[key]);
            }
            else if (ItemDB.Items[key] is ProtecterInfo)
            {
                Data.Inventory.Add(ItemDB.Items[key]);
            }
            else
            {
                Data.Inventory.Add(ItemDB.Items[key]);
            }
        }
    }
}
