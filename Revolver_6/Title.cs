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

            Helper.Typing("", "\n아무키나 눌러주세요.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">>  ");
            Console.ResetColor();

            Console.ReadKey();
            //캐릭터 생성
            //직업 선택
            GameHome();
        }

        static void GameHome()
        {
            Console.Clear();
            Helper.Typing("", "스파르타 던전에 오신 여러분 환영합니다.");
            Helper.Typing("", "이제 전투를 시작할 수 있습니다");

            Helper.Typing("", "1. 상태 보기", 0);
            Helper.Typing("", "2. 전투 시작", 0);
            Helper.Typing("", "0. 게임 종료", 0);



            Helper.Typing("", "원하시는 행동을 입력해주세요");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">>  ");
            Console.ResetColor();

            int input = Helper.WhatNum(0, 2);

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

                case 0:
                    Helper.Typing("Red", "게임을 종료합니다.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }
    }
}