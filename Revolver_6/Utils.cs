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

        public static void LevelUp(int value)
        {
            Data.Player.Exp += value;

            if (Player.Exp >= Player.Level * 30)
            {
                Player.Exp -= Player.Level * 30;
                Player.Level++;
                Helper.Typing("green","축하합니다!","blue",$"{Data.Player.Level}","green","이 되었습니다!");
            }
        }

        public static void GainExp()
        {
            int sum = 0;
            for (int i = 0; i < Data.monster.Length; i++) // 몬스터의 수 만큼 반복
            {
                sum += monster[i].Exp;                  // 몬스터의 key에 해당하는 경험치를 sum에 더함
            }
            Player.Exp += sum;                            // sum을 Player.Exp에 더함(적용시킴)
        }

        public static void GainGold()
        {
            int sum = 0;
            for (int i = 0; i < Data.monster.Length; i++)
            {
                sum += monster[i].Gold;
            }
            Player.Gold += sum; 
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
    }

    public class ItemManager
    {
        public static void AddItem(int key)
        {
            Inventory.Add(ItemDB.Items[key]);
        }
    }

}
