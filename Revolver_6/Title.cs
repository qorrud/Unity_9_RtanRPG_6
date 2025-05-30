using static Revolver_6.Data;

namespace Revolver_6
{
    internal class Title
    {
        public void GameStart()
        {
            GameTitle();
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

                if (input == "n") { }
            }
            return Name;
        }

        public ClassType ReadJob()
        {
            Console.Clear();
            Helper.Typing("yellow", "■■■\t직업 선택\t■■■");

            ClassType Job = ClassType.knight;

            bool check = false;

            while (!check)
            {
                JobInfo.Jobinfo();

                Helper.TypingWrite("yellow", "\n>> ");
                int JobIndex = Helper.WhatNum(1, 4);

                switch (JobIndex)
                {
                    case 1:
                        Job = ClassType.knight;
                        break;

                    case 2:
                        Job = ClassType.archer;
                        break;
                    case 3:
                        Job = ClassType.rogue;
                        break;

                    case 4:
                        Job = ClassType.magician;
                        break;
                }


                Helper.TypingWrite("yellow", "\n>> ");

                Helper.Typing("", "선택하신 직업이 \'", "green", Job, "", "\' 맞습니까?");
                string input = Helper.YesOrNo();

                if (input == "y")
                {
                    check = true;
                }

                if (input == "n") { }
            }
            return Job;
        }


        public void GameTitle()
        {
            Helper.Typing("yellow", "\n      ___           ___           ___           ___           ___           ___           ___     \r\n     /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\__\\    \r\n    /::\\  \\       /::\\  \\       /::\\  \\       /::\\  \\        \\:\\  \\       /::\\  \\       /::|  |   \r\n   /:/\\ \\  \\     /:/\\:\\  \\     /:/\\:\\  \\     /:/\\:\\  \\        \\:\\  \\     /:/\\:\\  \\     /:|:|  |   \r\n  _\\:\\~\\ \\  \\   /::\\~\\:\\  \\   /::\\~\\:\\  \\   /::\\~\\:\\  \\       /::\\  \\   /::\\~\\:\\  \\   /:/|:|  |__ \r\n /\\ \\:\\ \\ \\__\\ /:/\\:\\ \\:\\__\\ /:/\\:\\ \\:\\__\\ /:/\\:\\ \\:\\__\\     /:/\\:\\__\\ /:/\\:\\ \\:\\__\\ /:/ |:| /\\__\\\r\n \\:\\ \\:\\ \\/__/ \\/__\\:\\/:/  / \\/__\\:\\/:/  / \\/_|::\\/:/  /    /:/  \\/__/ \\/__\\:\\/:/  / \\/__|:|/:/  /\r\n  \\:\\ \\:\\__\\        \\::/  /       \\::/  /     |:|::/  /    /:/  /           \\::/  /      |:/:/  / \r\n   \\:\\/:/  /         \\/__/        /:/  /      |:|\\/__/     \\/__/            /:/  /       |::/  /  \r\n    \\::/  /                      /:/  /       |:|  |                       /:/  /        /:/  /   \r\n     \\/__/                       \\/__/         \\|__|                       \\/__/         \\/__/    ", 0);
            Helper.Typing("", "\n스파르타 던전에 오신것을 환영합니다");

            Helper.Typing("", "\n1.캐릭터 생성\t2.불러오기\t3.게임 종료", 0);
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
            Helper.Typing("", "이제 전투를 시작할 수 있습니다", 0);

            Helper.Typing("", "\n1. 상태 보기", 0);
            Helper.Typing("", "2. 가방 보기", 0);
            Helper.Typing("", "3. 임무 보기", 0);
            Helper.Typing("", "4. 전투 하기", 0);
            Helper.Typing("", "5. 여관 가기", 0);
            Helper.Typing("", "6. 상점 가기", 0);
            Helper.Typing("", "7. 저장 하기", 0);
            Helper.Typing("", "8. 게임 종료", 0);



            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 8);

            switch (input) //1상태, [2가방], [3임무], 4전투, [5여관], [6상점] ,[7저장], 8종료
            {
                case 1:
                    Console.Clear();
                    //상태
                    GameProfile();
                    break;

                case 2:
                    //가방
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
                    //여관
                    GameHotel();
                    break;

                case 6:
                    Shop.ShowShop(GameManager.Instance.DummyInt1, GameManager.Instance.DummyInt2, GameManager.Instance.DummyInt3);
                    break;

                case 7:
                    Console.Clear();
                    //저장
                    Helper.Typing("", "아직 구현되지 않은 기능입니다.");
                    Thread.Sleep(1000);
                    GameHome(); // 세이브 기능 만들면 추가
                    break;

                case 8:
                    Helper.Typing("Red", "게임을 종료합니다.");
                    //종료
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
                    GameInventory();
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }

        public void GameEqment()
        {
            GameManager.Instance.ShowInventory();
            Helper.Typing("", "\n원하시는 장비 번호를 입력해주세요.");
            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, Data.Inventory.Count);
            Inventory[input-1].EqItem();
        }

        public void GameInventory()
        {
            Console.Clear();
            Helper.Typing("yellow", "■■■\t가방\t■■■");

            GameManager.Instance.ShowInventory();

            Helper.Typing("", "\n1. 장착/해제", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 2);

            switch (input)
            {
                case 1:
                    Console.Clear();
                    GameEqment();
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
                    monster = MonsterData.MonsterFactory.MonsterSpawn();
                    //Battle.My_Phase();
                    GameBattlefloor();
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }

        public void GameBattlefloor()
        {
            Helper.Typing("yellow", "■■■\t전투\t■■■");
            Helper.Typing("", "\n몇 층으로 들어가시겠습니까?");

            Helper.Typing("", "\n[1] 1층부터 도전하기", 0);
            Helper.Typing("", "[2] 2층부터 도전하기", 0);
            Helper.Typing("", "[3] 3층부터 도전하기", 0);
            Helper.Typing("", "[4] 4층부터 도전하기", 0);
            Helper.Typing("", "[5] 5층부터 도전하기", 0);


            Helper.Typing("", "\n6. 돌아가기\n원하시는 행동을 입력해주세요", 0);

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(0, 5);

            switch (input)
            {

                case 1:
                    GameManager.Instance.Difficulty = 3;
                    Battle.mystage = 1;
                    Battle.My_Phase();
                    break;

                case 2:
                    GameManager.Instance.Difficulty = 6;
                    Battle.mystage = 1;
                    Battle.My_Phase();
                    break;

                case 3:
                    GameManager.Instance.Difficulty = 9;
                    Battle.mystage = 1;
                    Battle.My_Phase();
                    break;

                case 4:
                    GameManager.Instance.Difficulty = 12;
                    Battle.mystage = 1;
                    Battle.My_Phase();
                    break;

                case 5:
                    GameManager.Instance.Difficulty = 15;
                    Battle.mystage = 1;
                    Battle.My_Phase();
                    break;

                case 6:
                    GameHome();
                    break;
            }

        }

        public void GameHotel()
        {
            Helper.Typing("yellow", "■■■\t여관\t■■■");

            Helper.Typing("", "\n지친 플레이어의 체력을 회복시켜 줄 수 있는 공간입니다.");

            Helper.Typing("", "\n1. 휴식", 0);
            Helper.Typing("", "2. 돌아가기", 0);

            Helper.Typing("", "\n원하시는 행동을 입력해주세요");

            Helper.TypingWrite("yellow", "\n>> ");

            int input = Helper.WhatNum(1, 2);

            switch (input)
            {
                case 1:
                    Inn.InnIntro();
                    break;

                case 2:
                    Console.Clear();
                    GameHome();
                    break;
            }
        }
    }
}