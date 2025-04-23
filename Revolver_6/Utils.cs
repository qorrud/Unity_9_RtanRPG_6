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
                        Helper.Typing("green", "체력이 ", "", "가득찼다! \n현재 체력 : ","", Player.CurrentHP);
                    }

                    Helper.Typing("","현재 체력 : ","", Player.CurrentHP);
                    Console.ReadLine();
                    break;

                case "":
                    break;

            }
        }
    }

    public class ItemManager
    {
        public void AddItem(int key)
        {
            Inventory.Add(ItemDB.Items[key]);
        }
    }
}
