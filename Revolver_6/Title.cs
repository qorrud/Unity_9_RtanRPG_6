namespace Revolver_6
{
    internal class Title
    {
        public static void GameStart()
        {
            GameTitle();
        }

        static void GameTitle()
        {
            Helper.Typing("yellow", "\n      ___           ___           ___           ___           ___           ___           ___     \r\n     /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\__\\    \r\n    /::\\  \\       /::\\  \\       /::\\  \\       /::\\  \\        \\:\\  \\       /::\\  \\       /::|  |   \r\n   /:/\\ \\  \\     /:/\\:\\  \\     /:/\\:\\  \\     /:/\\:\\  \\        \\:\\  \\     /:/\\:\\  \\     /:|:|  |   \r\n  _\\:\\~\\ \\  \\   /::\\~\\:\\  \\   /::\\~\\:\\  \\   /::\\~\\:\\  \\       /::\\  \\   /::\\~\\:\\  \\   /:/|:|  |__ \r\n /\\ \\:\\ \\ \\__\\ /:/\\:\\ \\:\\__\\ /:/\\:\\ \\:\\__\\ /:/\\:\\ \\:\\__\\     /:/\\:\\__\\ /:/\\:\\ \\:\\__\\ /:/ |:| /\\__\\\r\n \\:\\ \\:\\ \\/__/ \\/__\\:\\/:/  / \\/__\\:\\/:/  / \\/_|::\\/:/  /    /:/  \\/__/ \\/__\\:\\/:/  / \\/__|:|/:/  /\r\n  \\:\\ \\:\\__\\        \\::/  /       \\::/  /     |:|::/  /    /:/  /           \\::/  /      |:/:/  / \r\n   \\:\\/:/  /         \\/__/        /:/  /      |:|\\/__/     \\/__/            /:/  /       |::/  /  \r\n    \\::/  /                      /:/  /       |:|  |                       /:/  /        /:/  /   \r\n     \\/__/                       \\/__/         \\|__|                       \\/__/         \\/__/    ", 0);
            Helper.Typing("", "\n스파르타 던전에 오신것을 환영합니다");

            Helper.Typing("", "\n1.캐릭터 생성\t2.불러오기\t3.게임 종료");
            Helper.Typing("", "\n원하시는 행동을 입력해주세요.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n>>  ");
            Console.ResetColor();

            int input = Helper.WhatNum(1, 3);

            switch (input) //캐릭터 생성, 로드
            {
                case 1:
                    // 캐릭터 이름 짓기, 직업선택
                    Helper.Typing("red", "스파르타에 찾아온, 당신의 이름은 무엇입니까?");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(">>  ");
                    Console.ResetColor();

                    //프로필에 네임 = Console.ReadLine() ?? "";

                    //{이름},이 맞습니까?

                    //string inputA = Helper.YesOrNo

                    GameHome();
                    break;

                case 2:
                    // 데이터 로드
                    Helper.Typing("", "미구현된 기능입니다.");
                    GameHome();
                    break;

                case 3:
                    Helper.Typing("Red", "게임을 종료합니다.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }

        static void GameHome()
        {
            Console.Clear();
            Helper.Typing("", "스파르타 던전에 오신 여러분 환영합니다.");
            Helper.Typing("", "이제 전투를 시작할 수 있습니다");

            Helper.Typing("", "\n1. 상태 보기", 0);
            Helper.Typing("", "2. 전투 시작", 0);
            Helper.Typing("", "3. 게임 종료", 0);



            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n>>  ");
            Console.ResetColor();

            int input = Helper.WhatNum(1, 3);

            switch (input)
            {
                case 1:
                    Console.Clear();
                    //상태창
                    break;

                case 2:
                    Console.Clear();
                    //전투 시작
                    break;

                case 3:
                    Helper.Typing("Red", "게임을 종료합니다.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }
    }
}