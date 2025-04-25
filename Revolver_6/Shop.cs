namespace Revolver_6
{
    public class Shop
    {
        public static void ShowShop(int[] a, int[] b, int[] c) 
        {
            Helper.Typing("", "판매 목록 : ", "red", "무기", 0);
            for (int i = 0; i < a.Length; i++)
            {
                Helper.Typing("", $"{i+1}번째 상품",0);
                ItemDB.Items[a[i]].ShowItem();
            }
            Console.WriteLine();

            Helper.Typing("", "판매 목록 : ", "red", "방어구", 0);
            for (int i = 0; i < b.Length; i++)
            {
                Helper.Typing("", $"{i+1}번째 상품",0);
                ItemDB.Items[b[i]].ShowItem();
            }
            Console.WriteLine();

            Helper.Typing("", "판매 목록 : ", "green", "기타", 0);
            for (int i = 0; i < c.Length; i++)
            {
                Helper.Typing("", $"{i+1}번째 상품",0);
                ItemDB.Items[c[i]].ShowItem();
            }
            Console.WriteLine();

            Helper.TypingWrite("", "원하시는 행동을 선택해주세요");
        }
    }
}