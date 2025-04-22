namespace Revolver_6
{
    internal class Title
    {
        public static void GameStart()
        {
            //GameTitle();
            GameHome();
        }

        static void GameTitle()
        {
            Helper.Typing("","스파르타 던전에 오신것을 환영합니다");
            //캐릭터 생성
            //직업 선택
            GameHome();
        }

        static void GameHome()
        {
            Console.Clear();
            Helper.Typing("","스파르타 던전에 오신 여러분 환영합니다.");
            Helper.Typing("","이제 전투를 시작할 수 있습니다");

            Helper.Typing("", "1. 상태 보기");
            Helper.Typing("", "2. 전투 시작");
            Helper.Typing("", "0. 게임 종료");

            while (true)
            {
                Helper.Typing("", "원하시는 행동을 입력해주세요");
                Console.Write(">>  ");

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
}