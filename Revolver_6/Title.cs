namespace Revolver_6
{
    internal class Title
    {
        public void GameStart()
        {
            GameTitle();
        }

        public ClassType ReadJob()
        {
            // 소개글 메서드 실행
            ClassType Job = ClassType.knight;
            bool check = false;
            while (!check) 
            {
                int JobIndex = Helper.WhatNum(1,4);
                Job = (ClassType)JobIndex;
                Helper.Typing("", "선택하신 직업이 \'", "green", Job, "", "\' 맞습니까?");
                string input = Helper.YesOrNo();
                if (input == "y")
                {
                    check = true;
                }
                if (input == "n");
            }
            return Job;
        }

        public string ReadName()
        {
            string Name = "";
            bool check = false;
            while (!check) 
            {
                Name = Console.ReadLine() ?? "Null";
                Helper.Typing("", "선택하신 이름이 \'", "green", Name, "", "\' 맞습니까?");
                string input = Helper.YesOrNo();
                if (input == "y")
                {
                    check = true;
                }
                if (input == "n");
            }
            return Name;
        }
        public void GameTitle()
        {
            Helper.Typing("yellow", "\n      ___           ___           ___           ___           ___           ___           ___     \r\n     /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\__\\    \r\n    /::\\  \\       /::\\  \\       /::\\  \\       /::\\  \\        \\:\\  \\       /::\\  \\       /::|  |   \r\n   /:/\\ \\  \\     /:/\\:\\  \\     /:/\\:\\  \\     /:/\\:\\  \\        \\:\\  \\     /:/\\:\\  \\     /:|:|  |   \r\n  _\\:\\~\\ \\  \\   /::\\~\\:\\  \\   /::\\~\\:\\  \\   /::\\~\\:\\  \\       /::\\  \\   /::\\~\\:\\  \\   /:/|:|  |__ \r\n /\\ \\:\\ \\ \\__\\ /:/\\:\\ \\:\\__\\ /:/\\:\\ \\:\\__\\ /:/\\:\\ \\:\\__\\     /:/\\:\\__\\ /:/\\:\\ \\:\\__\\ /:/ |:| /\\__\\\r\n \\:\\ \\:\\ \\/__/ \\/__\\:\\/:/  / \\/__\\:\\/:/  / \\/_|::\\/:/  /    /:/  \\/__/ \\/__\\:\\/:/  / \\/__|:|/:/  /\r\n  \\:\\ \\:\\__\\        \\::/  /       \\::/  /     |:|::/  /    /:/  /           \\::/  /      |:/:/  / \r\n   \\:\\/:/  /         \\/__/        /:/  /      |:|\\/__/     \\/__/            /:/  /       |::/  /  \r\n    \\::/  /                      /:/  /       |:|  |                       /:/  /        /:/  /   \r\n     \\/__/                       \\/__/         \\|__|                       \\/__/         \\/__/    ", 0);
            Helper.Typing("", "\n스파르타 던전에 오신것을 환영합니다");

            Helper.Typing("", "\n1.캐릭터 생성\t2.불러오기\t3.게임 종료");
            Helper.Typing("", "\n원하시는 행동을 입력해주세요.");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 3);

            switch (input) //캐릭터 생성, 로드
            {
                case 1:
                    // 캐릭터 이름 짓기, 직업선택
                    Helper.Typing("red", "스파르타에 찾아온, 당신의 이름은 무엇입니까?");
                    Helper.TypingWrite("yellow", "\n>> ");              
                    break;

                case 2:
                    // 데이터 로드
                    Helper.Typing("", "아직 구현되지 않은 기능입니다.");
                    Thread.Sleep(1000);
                    GameHome();
                    break;

                case 3:
                    Helper.Typing("Red", "게임을 종료합니다.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }

        public void GameHome()
        {
            Console.Clear();
            Helper.Typing("", "스파르타 던전에 오신 여러분 환영합니다.");
            Helper.Typing("", "이제 전투를 시작할 수 있습니다");

            Helper.Typing("", "\n1. 상태 보기", 0);
            Helper.Typing("", "2. 가방 보기");
            Helper.Typing("", "3. 임무 보기");
            Helper.Typing("", "4. 전투 하기");
            Helper.Typing("", "5. 저장 하기", 0);
            Helper.Typing("", "6. 게임 종료", 0);



            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 6);

            switch (input) //상태, [가방], [임무] ,전투 ,[저장], 종료
            {
                case 1:
                    Console.Clear();
                    GameProfile();
                    break;

                case 2:
                    Console.Clear();
                    GameInventory();
                    break;

                case 3:
                    Console.Clear();
                    //임무
                    GameQuest();
                    break;

                case 4:
                    Console.Clear();
                    //전투 시작
                    GameBattle();
                    break;

                case 5:
                    Console.Clear();
                    //저장
                    Helper.Typing("", "아직 구현되지 않은 기능입니다.");
                    Thread.Sleep(1000);
                    GameHome(); // 세이브 기능 만들면 추가
                    break;

                case 6:
                    Helper.Typing("Red", "게임을 종료합니다.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }

        public void GameProfile()
        {
            Helper.Typing("yellow", "■■■\t상태창\t■■■");
            Profile.PlayerStats();

            Helper.Typing("", "\n1. 장비관리", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 2);

            switch (input)
            {
                case 1:
                    //장비관리
                    Helper.Typing("", "아직 구현되지 않은 기능입니다.");
                    Thread.Sleep(1000);
                    GameHome();
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }

        public void GameInventory()
        {
            Helper.Typing("yellow", "■■■\t가방\t■■■");

            //for () { } // 아이템 리스트

            Helper.Typing("", "\n1. 장비관리", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 2);

            switch (input)
            {
                case 1:
                    //장비관리
                    Helper.Typing("", "아직 구현되지 않은 기능입니다.");
                    Thread.Sleep(1000);
                    GameHome();
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }

        public void GameQuest()
        {
            Helper.Typing("yellow", "■■■\t임무\t■■■");

            //for () { } // 퀘스트 리스트

            Helper.Typing("", "\n1. 퀘스트 관리", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 2);

            switch (input)
            {
                case 1:
                    //퀘스트 관리
                    Helper.Typing("", "아직 구현되지 않은 기능입니다.");
                    Thread.Sleep(1000);
                    GameHome();
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }

        public void GameBattle()
        {
            Helper.Typing("yellow", "■■■\t전투\t■■■");

            //for () { } // 리스트?

            Helper.Typing("", "\n1. 싸우러 가기", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 2);

            switch (input)
            {
                case 1:
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }
    }
}