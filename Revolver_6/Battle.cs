using static Revolver_6.Helper;
using static Revolver_6.Data;
using System.Security.Cryptography.X509Certificates;

namespace Revolver_6
{
    internal static class Battle
    {
        static int mystage = 0;

        static bool Player_turn = true; //플레이어의 턴은 true 몬스터의 턴은 false로 할게요
        static int Monster_count = monster.Length; //몬스터 개수를 새기위한 카운트입니다. Dead 됐을시 1개씩 차감하고 0이되면 전투에서 승리한 걸로 취급

        static int rage = 0; // 쓸 지는 모르겠지만 광폭화 스택입니다. 플레이어, 몬스터의 턴이 끝나면 1씩 증가하고 일정 수치 이상이 된다면 몬스터의 스탯이 뻥튀기 되는 거 넣어볼 생각인데 나중에..

        internal static void My_Phase()
        //플레이어의 턴일때 실행되는 함수입니다. 플레이어의 턴이 끝나면  turn 은 false로 변경해서 적의 턴으로 넘어갑니다.
        {
            int floor = GameManager.Instance.Difficulty / 3; // 층 숫자
            mystage = (mystage % 3) + 1; // 구역 숫자

            int Player_baseAttack = Player.Power;

            int Player_error = (int)Math.Ceiling(Player_baseAttack * 0.1); //공격력의 오차 설정
            int min = Player_baseAttack - Player_error; //최소 데미지
            int max = Player_baseAttack + Player_error; //최대 데미지
            Random random = new Random();
            int player_damage = random.Next((int)min, (int)max + 1); // 오차에 따른 랜덤 데미지 설정하기


            Console.Clear();

            Typing("Red", "Battle!");

            Typing("", $"{floor}층 - {mystage}구역", 0); // 층 구역 정보 추가

            MonsterData.MonsterStat.Display(monster); // 몬스터 정보를 출력합니다.

            Console.WriteLine();
            Console.WriteLine();
            Typing("white", $"[내정보]\nLv.{Player.Level}  {Player.Name} ({Player.Job})\nHP {Player.MaxHp}/{Player.CurrentHP}\n");
            Typing("Yellow", $"예상 데미지 {min} ~ {max}\n");
            //플레이어의 정보 출력합니다.

            //Profile.Player(); 


            Typing("white", "1. 공격\n원하시는 행동을 입력해주세요.\n>>");
            WhatNum(1, 1); //return 값은 index


            // 공격 선택시
            //MonsterData.MonsterStat.Display(monster);


            Typing("white", $"대상을 선택해주세요. (1~{monster.Length})\n>>"); //n번째 몬스터 인덱스 출력

            int input = WhatNum(1, monster.Length) - 1;

            while ((monster[input].HP == 0))
            {

                Typing("yellow", "죽은 몬스터는 공격 할 수 없습니다!");
                Typing("white", $"대상을 선택해주세요. (1~{monster.Length})\n>>"); //n번째 몬스터 인덱스 출력

                input = WhatNum(1, monster.Length) - 1;


            }


            //몬스터 생성 로직에 따라 코드 넣을 생각입니다. 



            bool iscritical = false; //크리티컬뜸?
            bool isavoid = CheckAvoid(); //피함?
            if (isavoid) // 10%확률로 회피했으면 데미지 0
            {

                
                player_damage = 0;
                
            }
            else
            {
                iscritical = CheckCritical();
                if (iscritical)
                {
                    player_damage = (int)Math.Ceiling(player_damage * 1.6);
                    //크리티컬 발생시 데미지 1.6배로전환합니다.

                }

            }

<<<<<<< Updated upstream



            Typing("Red", "Battle!\n");
            Typing("white", $"{Player.Name}의 공격!");
            TypingWrite("white", $"Lv.");
            TypingWrite("red", $"{monster[input].Level}");
            if (isavoid == true) //회피했을때
            {
                TypingWrite("white", $" {monster[input].Name}을(를) 공격했지만 아무 일도 일어나지 않았습니다...\n"); //TypingWrite 함수 갱신되기 전에 사용
                isavoid = false;

            }
            else //회피 안했을때
            {
                TypingWrite("white", $" {monster[input].Name}을(를) 맞췄습니다. [데미지 : "); //TypingWrite 함수 갱신되기 전에 사용
                TypingWrite("red", $"{player_damage}");
              
                if (iscritical == true && isavoid == false)
=======
                bool iscritical = false; //크리티컬뜸?
                bool isavoid = CheckAvoid(); //피함?
                if (isavoid) // 10%확률로 회피했으면 데미지 0
>>>>>>> Stashed changes
                {
                    TypingWrite("white", "]");
                    TypingWrite("red", " - 치명타 공격!\n");
                }
                else
                {
                    TypingWrite("white", "]\n");

                }




                }



            TypingWrite("white", $"Lv.");
            TypingWrite("red", $"{monster[input].Level} ");
            TypingWrite("white", $"{monster[input].Name}\n");
            TypingWrite("white", "HP ");
            TypingWrite("red", $"{monster[input].HP}");

<<<<<<< Updated upstream
            TypingWrite("white", " ->");
            monster[input].HP -= player_damage; //데미지 계산
            if (monster[input].HP < 0) //체력이 마이너스가 되면 안되니까 음수로 되면 0으로 설정합니다.
=======
                TypingWrite("white", " ->");
                monster[input].HP -= player_damage; //데미지 계산
                if (monster[input].HP < 0) //체력이 마이너스가 되면 안되니까 음수로 되면 0으로 설정합니다.
                {

                    monster[input].HP = 0;
                }
                if (monster[input].HP == 0) // 몬스터의 체력이 0이 된다면 죽이는 로직
                {
                    TypingWrite("gray", " Dead\n");

                    Monster_count--;
                    Typing("red", "0.", "white", " 다음\n\n>>");

                    WhatNum(0, 0);
                    Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

                    Console.Clear();

                    Result.Player_Turn_End(Player_turn, Monster_count);
                }
                else //죽지 않았다면 남은 체력을 표시
                {
                    TypingWrite("white", $" {monster[input].HP} \n");



                    //Typing("red", "0.", "white", " 다음\n\n>>");

                    //WhatNum(0, 0);

                    //Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

                    //Console.Clear();

                    //Result.Player_Turn_End(Player_turn, Monster_count);


                }
            }
            // 스킬 선택시
            else if (Player_Action == 2)
>>>>>>> Stashed changes
            {

                monster[input].HP = 0;
            }
            if (monster[input].HP == 0) // 몬스터의 체력이 0이 된다면 죽이는 로직
            {
                TypingWrite("gray", " Dead\n");
                
                Monster_count--;
                Typing("red", "0.", "white", " 다음\n\n>>");

                WhatNum(0, 0);
                Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

                Console.Clear();

                Result.Player_Turn_End(Player_turn, Monster_count);
            }
            else //죽지 않았다면 남은 체력을 표시
            {
                TypingWrite("white", $" {monster[input].HP} \n");






                Typing("red", "0.", "white", " 다음\n\n>>");

                WhatNum(0, 0);

                Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

                Console.Clear();

                Result.Player_Turn_End(Player_turn, Monster_count);



<<<<<<< Updated upstream
=======
                        attmon = WhatNum(1, monster.Length) - 1;


                    }


                    Player.CurrentMP -= Player_skill.MySkillList[input - 1].Use_MP; //mp 소모


                    int skill_damage = (int)(Player.Power * Player_skill.MySkillList[input - 1].Damage); // 데미지 계산


                    Typing("Red", "Battle!\n");
                    Typing("white", $"{Player.Name}의 {Player_skill.MySkillList[input - 1].Skill_Name}!");
                    TypingWrite("white", $"Lv.");
                    TypingWrite("red", $"{monster[attmon - 1].Level}");


                    for (int i = 0; i < Player_skill.MySkillList[input - 1].AttackTry; i++) //스킬 공격

                    {
                        bool iscritical = false;   //크리티컬뜸?

                        //bool isavoid = CheckAvoid(); //피함?
                        //if (isavoid) // 10%확률로 회피했으면 데미지 0
                        //{


                        //    skill_damage = 0;

                        //}

                        iscritical = CheckCritical();
                        if (iscritical)
                        {
                            skill_damage = (int)Math.Ceiling(skill_damage * 1.6);
                            //크리티컬 발생시 데미지 1.6배로전환합니다.

                        }




                        //if (isavoid == true) //회피했을때  
                        //{
                        //    TypingWrite("white", $" {monster[attmon].Name}을(를) 공격했지만 아무 일도 일어나지 않았습니다...\n"); //TypingWrite 함수 갱신되기 전에 사용
                        //    isavoid = false;

                        //}
                        //회피 안했을때



                        // 아니 스킬은 회피가 안뜬다네요;;; 괜히 고민 했음
                        Typing("white", $" {monster[attmon].Name}을(를) 맞췄습니다.");


                        TypingWrite("white", $"{i + 1}번째 공격!");
                        TypingWrite("red", $" {skill_damage} 데미지\n");


                        if (iscritical == true)
                        {

                            TypingWrite("red", " - 치명타 공격!\n");
                        }



                        TypingWrite("white", $"Lv.");
                        TypingWrite("red", $"{monster[attmon].Level} ");
                        TypingWrite("white", $"{monster[attmon].Name}\n");
                        TypingWrite("white", "HP ");
                        TypingWrite("red", $"{monster[attmon].HP}");

                        TypingWrite("white", " ->");
                        monster[attmon].HP -= skill_damage; //데미지 계산
                        if (monster[attmon].HP < 0) //체력이 마이너스가 되면 안되니까 음수로 되면 0으로 설정합니다.
                        {

                            monster[attmon].HP = 0;
                        }
                        if (monster[attmon].HP == 0) // 몬스터의 체력이 0이 된다면 죽이는 로직
                        {
                            TypingWrite("gray", " Dead\n");

                            Monster_count--;
                            Typing("red", "0.", "white", " 다음\n\n>>");

                            WhatNum(0, 0);
                            Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

                            Console.Clear();

                            Result.Player_Turn_End(Player_turn, Monster_count);
                        }
                        else //죽지 않았다면 남은 체력을 표시
                        {
                            TypingWrite("white", $" {monster[attmon].HP} \n");

                        }

                    }

                }

                else if (Player_skill.MySkillList[input - 1].TargetType == monster.Length) // 단일 공격이 아닐 때 
                {
                    Player.CurrentMP -= Player_skill.MySkillList[input - 1].Use_MP; //mp 소모


                    int skill_damage = (int)(Player.Power * Player_skill.MySkillList[input - 1].Damage); // 데미지 계산


                    Typing("Red", "Battle!\n");
                    Typing("white", $"{Player.Name}의 {Player_skill.MySkillList[input - 1].Skill_Name}!");


                    for (int i = 0; i < monster.Length; i++)
                    {


                        bool iscritical = false;
                        iscritical = CheckCritical();
                        if (iscritical)
                        {
                            skill_damage = (int)Math.Ceiling(skill_damage * 1.6);


                            //크리티컬 발생시 데미지 1.6배로전환합니다.
                            Typing("white", $" {monster[i].Name}을(를) 맞췄습니다.");



                            TypingWrite("red", $" {skill_damage} 데미지");

                            if (iscritical == true)
                            {

                                TypingWrite("red", " - 치명타 공격!\n");

                                TypingWrite("\nwhite", $"Lv.");
                                TypingWrite("red", $"{monster[i].Level} ");
                                TypingWrite("white", $"{monster[i].Name}\n");
                                TypingWrite("white", "HP ");
                                TypingWrite("red", $"{monster[i].HP}");

                                TypingWrite("white", " ->");
                            }
                        }



                        else
                        {

                            TypingWrite("white", $" {monster[i].Name}을(를) 맞췄습니다.");



                            Typing("red", $" {skill_damage} 데미지");
                            TypingWrite("white", $"Lv.");
                            TypingWrite("red", $"{monster[i].Level} ");
                            TypingWrite("white", $"{monster[i].Name}\n");
                            TypingWrite("white", "HP ");
                            TypingWrite("red", $"{monster[i].HP}");

                            TypingWrite("white", " ->");

                        }

                        monster[i].HP -= skill_damage; //데미지 계산
                        if (monster[i].HP < 0) //체력이 마이너스가 되면 안되니까 음수로 되면 0으로 설정합니다.
                        {

                            monster[i].HP = 0;
                        }
                        if (monster[i].HP == 0) // 몬스터의 체력이 0이 된다면 죽이는 로직
                        {
                            TypingWrite("gray", " Dead\n");

                            Monster_count--;


                        }
                        else //죽지 않았다면 남은 체력을 표시
                        {
                            TypingWrite("white", $" {monster[i].HP} \n");
                        }
                    }
                }
>>>>>>> Stashed changes

            }
<<<<<<< Updated upstream
=======

            Typing("red", "0.", "white", " 다음\n\n>>");

            WhatNum(0, 0);

            Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

            Console.Clear();

            Result.Player_Turn_End(Player_turn, Monster_count);
>>>>>>> Stashed changes
        }

        internal static void Monster_Phase() //몬스터 턴입니다.
        {
            Typing("Red", "Battle!\n");
            MonsterData.MonsterStat.Display(monster); // 몬스터 정보
            for (int i = 0; i < monster.Length; i++)
            {
                if (monster[i].HP == 0) //몬스터가 죽었다면
                {

                    Typing("white", "Lv.", "red", $"{monster[i].Level}", "white", $" {monster[i].Name}은(는) 사망했기 때문에 공격 할 수 없다!");


                }
                else
                { //몬스터가 살아있다면


                    int Monster_baseAttack = monster[i].Attack;

                    int Monster_error = (int)Math.Ceiling(Monster_baseAttack * 0.1); //공격력의 오차 설정
                    int min = Monster_baseAttack - Monster_error; //최소 데미지
                    int max = Monster_baseAttack + Monster_error; //최대 데미지
                    Random random = new Random();
                    int Monster_damage = random.Next(min, max + 1); // 오차에 따른 랜덤 데미지 설정하기
                    Typing("white", "Lv.", "red", $"{monster[i].Level}", "white", $" {monster[i].Name}의 공격!");
                    TypingWrite("white", $"{Player.Name} 을(를) 맞췄습니다.");
                    TypingWrite("white", "    [데미지 : ");
                    TypingWrite("red", Monster_damage);
                    TypingWrite("white", "]\n\n");

                    Typing("white", "Lv.", "red", $"{Player.Level}  ", "white", $"{Player.Name}");
                    TypingWrite("white", "HP");
                    TypingWrite("red", $" {Player.CurrentHP} ");
                    TypingWrite("white", "-> ");

                    Player.CurrentHP -= Monster_damage; //데미지 입음


                    if (Player.CurrentHP < 0) //플레이어가 체력이 0이하가 됐을때
                    {
                        Player.CurrentHP = 0;
                        TypingWrite("red", $"{Player.CurrentHP}\n\n");

                        Typing("red", $"{Player.Name}은(는) 쓰러졌다!");
                        Typing("red", "눈앞이 캄캄해진다");
                        for (int k = 0; k < 3; k++)
                        {
                            Typing("white", ".");
                            Thread.Sleep(500);
                        }

                        Title title = new Title();
                        Console.Clear();
                        title.GameHome();


                    }
                    else //플레이어가 살아있을때
                    {
                        TypingWrite("red", $"{Player.CurrentHP}\n\n");

                        Typing("red", "0", "white", " 다음\n");
                        Typing("white", ">>");
                        WhatNum(0, 0);

                    }

                }


            }

            Player_turn = true; //몬스터의 턴이 끝나면 플레이어의 턴을 실행합니다.
            rage++;
            Rage();
            My_Phase();
        }
<<<<<<< Updated upstream
        

=======

        internal static void NewBattle()
        {
            Player_turn = true;
            Monster_count = monster.Length;
        }
>>>>>>> Stashed changes
        internal static void Rage() //rage가 5이상 부터 몬스터 공격력 체력 2배로 증가
        {
            if (rage >= 5)
            {
                for (int i = 0; monster.Length > i; i++)
                {
                    monster[i].Attack *= 2;
                    monster[i].HP *= 2;
                }


                Typing("red", "\n몬스터들이 광폭화 상태가 되었습니다! 공격력과 체력이 2배로 증가합니다!\n");
                rage = 0;
            }
        }

        internal static bool CheckAvoid() //회피 체크 함수
        {

            Random random = new Random();
            int avoidChance = random.Next(1, 101); // 1~100 사이의 숫자
            return avoidChance <= 10; // 10% 확률로 회피
        }

        internal static bool CheckCritical() //크리티컬 체크 함수
        {


            Random random = new Random();
            int criticalChance = random.Next(1, 101);
            return criticalChance <= 15;
        }
    }
}