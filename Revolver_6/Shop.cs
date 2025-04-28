namespace Revolver_6
{
    internal class Shop
    {
        public static void ShowShop(int[] a, int[] b, int[] c)
        {
            Helper.Typing("", "판매 목록 : ", "red", "무기", 0);
            for (int i = 0; i < a.Length; i++)
            {
                Helper.Typing("", $"{i + 1}번째 상품", 0);
                ItemDB.Items[a[i]].ShowItem();
            }
            Console.WriteLine();

            Helper.Typing("", "판매 목록 : ", "red", "방어구", 0);
            for (int i = 0; i < b.Length; i++)
            {
                Helper.Typing("", $"{i + 1}번째 상품", 0);
                ItemDB.Items[b[i]].ShowItem();
            }
            Console.WriteLine();

            Helper.Typing("", "판매 목록 : ", "green", "기타", 0);
            for (int i = 0; i < c.Length; i++)
            {
                Helper.Typing("", $"{i + 1}번째 상품", 0);
                ItemDB.Items[c[i]].ShowItem();
            }
            Console.WriteLine();

            Helper.Typing("", "원하시는 행동을 선택 해주세요");
            Helper.Typing("", "\n1. 구매", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            int input = Helper.WhatNum(1, 2);
            if (input == 1)
            {
                Helper.Typing("", "어떤 아이템을 구매하시겠습니까?");
                Helper.Typing("", "\n1. 무기", 0);
                Helper.Typing("", "2. 방어구", 0);
                Helper.Typing("", "3. 공용아이템", 0);
                Helper.Typing("", "4. 돌아가기", 0);

                int answer1 = Helper.WhatNum(1, 4);
                if (answer1 == 4)
                {
                    GameManager.Instance.title.GameHome();
                }

                Helper.Typing("", "구매를 원하는 아이템 번호를 선택 해주세요");

                int answer2 = Helper.WhatNum(1, 100);
                Purchase(answer1, answer2);
            }
            else if (input == 2)
            {
                Console.Clear();
                GameManager.Instance.title.GameHome();
            }
        }

        public static void Purchase(int Type, int answer)
        {
            switch (Type)
            {
                case 1:
                    if (Data.Player.Gold >= ItemDB.Items[GameManager.Instance.DummyInt1[answer - 1]].Cost)
                    {
                        Data.Player.Gold -= GameManager.Instance.DummyInt1[answer - 1];
                        ItemManager.AddItem(ItemDB.Items[GameManager.Instance.DummyInt1[answer - 1]].Index);

                        Helper.Typing("yellow", "성공적으로 ", "", "구매를 완료 했습니다!");
                        ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    }
                    else
                    {
                        Helper.Typing("", "보유중인 ", "yellow", "골드가", "", " 모자랍니다");
                        ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    }

                    break;

                case 2:
                    if (Data.Player.Gold >= ItemDB.Items[GameManager.Instance.DummyInt2[answer - 1]].Cost)
                    {
                        Data.Player.Gold -= GameManager.Instance.DummyInt2[answer - 1];
                        ItemManager.AddItem(ItemDB.Items[GameManager.Instance.DummyInt2[answer - 1]].Index);

                        Helper.Typing("yellow", "성공적으로 ", "", "구매를 완료 했습니다!");
                        ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    }
                    else
                    {
                        Helper.Typing("", "보유중인 ", "yellow", "골드가", "", " 모자랍니다");
                        ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    }
                    break;

                case 3:
                    if (Data.Player.Gold >= ItemDB.Items[GameManager.Instance.DummyInt3[answer - 1]].Cost)
                    {
                        Data.Player.Gold -= GameManager.Instance.DummyInt3[answer - 1];
                        ItemManager.AddItem(ItemDB.Items[GameManager.Instance.DummyInt3[answer - 1]].Index);

                        Helper.Typing("yellow", "성공적으로 ", "", "구매를 완료 했습니다!");
                        ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    }
                    else
                    {
                        Helper.Typing("", "보유중인 ", "yellow", "골드가", "", " 모자랍니다");
                        ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    }
                    break;
            }
        }
    }
}