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

        // public void PlayerExp(int value)
        // {
        //     Data.Player.Exp += value;

        //     if (Player.Exp >= Player.Level * 10)
        //     {
        //         Player.Exp -= Player.Level;
        //         Player.Level++;
        //     }
        // }

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
