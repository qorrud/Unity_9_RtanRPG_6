using System.Security.Cryptography.X509Certificates;
using static Revolver_6.Data;

namespace Revolver_6
{
    internal class Utils
    {
        public class ExtraEffect
        {
            public void UseEffect(string name, int value = 0)
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
                            Player.CurrentHP = Player.MaxHp;
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
                Inventory.Add(Item.ItemDB.Items[key]);
            }
        }
    }
}