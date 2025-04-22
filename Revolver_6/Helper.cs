namespace Revolver_6
{
    internal static class Helper
    {

        public static void SelectColor(string input)
        {
            if (Enum.TryParse(input, true, out ConsoleColor color))
            {
                Console.ForegroundColor = color; // 색 입력하면 해당색으로 변경
            }
            else
            {
                Console.ResetColor();
            }
        }

        public static void Typing(string color1, object input1, int speed = 50)
        {
            SelectColor(color1);
            string text1 = input1.ToString();
            foreach (char c in text1)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        public static void Typing(string color1, object input1, string color2, object input2, int speed = 50)
        {
            SelectColor(color1);
            string text1 = input1.ToString();
            foreach (char c in text1)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }

            SelectColor(color2);
            string text2 = input2.ToString();
            foreach (char c in text2)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        public static void Typing(string color1, object input1, string color2,
         object input2, string color3, object input3, int speed = 50)
        {
            SelectColor(color1);
            string text1 = input1.ToString();
            foreach (char c in text1)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            SelectColor(color2);
            string text2 = input2.ToString();
            foreach (char c in text2)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            SelectColor(color3);
            string text3 = input3.ToString();
            foreach (char c in text3)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        // 사용방법 - Typing("색", "내용")
        // 색 혼합해서 사용할려면 - Typing("색1", "내용1", "색2", "내용2")


        public static string YesOrNo() // Yes or No 반환하는 함수
        {
            while (true)
            {
                Typing("", "(Y/N) 입력 : ");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (input == "y")
                {
                    return "y";
                }
                else if (input == "n")
                {
                    return "n";
                }
                else
                {
                    Typing("red", "Y/N", "", "를 입력 해주십시오");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

        }
        // 사용방법 string input = YesOrNo(); 하면 input은 y or n 값을 받음


        public static int WhatNum(int a, int b) // 숫자 입력 검증 메서드
        {
            int index = -1;
            while (true)
            {
                string input = Console.ReadLine();
                bool isNum = int.TryParse(input, out index);

                if (a <= index && index <= b)
                    break;
                else
                {
                    Typing("red", "유효한 ", "", "숫자를 입력 해주십시오");
                    Console.WriteLine();
                }
            }
            return index;
        }
        // 사용방법 int input = WhatNum(1, 3); 하면 input은 사용자가 입력한 1~3 숫자값을 받음
    }
}