using static Revolver_6.Helper;
using static Revolver_6.Data;
using System.Security.Cryptography.X509Certificates;

namespace Revolver_6
{
    internal static class Battle
    {

        static bool Player_turn = true; //플레이어의 턴은 true 몬스터의 턴은 false로 할게요
        static int Monster_count = MonsterData.MonsterList.Count; //몬스터 개수를 새기위한 카운트입니다. Dead 됐을시 1개씩 차감하고 0이되면 전투에서 승리한 걸로 취급


        //int rage = 0; // 쓸 지는 모르겠지만 광폭화 스택입니다. 플레이어, 몬스터의 턴이 끝나면 1씩 증가하고 일정 수치 이상이 된다면 몬스터의 스탯이 뻥튀기 되는 거 넣어볼 생각인데 나중에..

        internal static void My_Phase()
        //플레이어의 턴일때 실행되는 함수입니다. 플레이어의 턴이 끝나면  turn 은 false로 변경해서 적의 턴으로 넘어갑니다.
        {
            //MonsterFactory() 랜덤 몬스터 소환 로직 넣을껍니다.


            Typing("Red", "Battle!");
            foreach (MonsterData.MonsterStat monster in MonsterData.MonsterList) // 몬스터 정보입니다.
            {
                monster.Display();


            }

            Console.WriteLine();
            Console.WriteLine();
            Typing("white", $"[내정보]\nLv.{Player.Level}  {Player.Level} ({Player.Level})\nHP {Player.MaxHp}/{Player.CurrentHP}\n");
            //플레이어의 정보 출력합니다.

            //Profile.Player(); 


            Typing("white", "1. 공격\n원하시는 행동을 입력해주세요.\n>>");
            WhatNum(1, 1); //return 값은 index
            Console.Clear();

            // 공격 선택시
            int monster_index = 1; //몬스터 출현시 붙일 번호입니다. 1번부터 선언

            foreach (MonsterData.MonsterStat monster in MonsterData.MonsterList) // 몬스터 정보입니다.
            {
                Console.Write(monster_index); //몬스터 인덱스 출력 타이핑으로 쓰고싶은데 writeline으로 되어있어서 어케 해야할 지 모르겠어서 이렇게 씀
                monster.Display();
                monster_index++;

            }

            Typing("Black", $"대상을 선택해주세요. (1~{monster_index - 1}\n>>"); //n번째 몬스터 인덱스 출력하면 몬스터 인덱스값이 n+1되서 -1함

            int input = WhatNum(1, monster_index - 1);
            Console.Clear();

            //몬스터 생성 로직에 따라 코드 넣을 생각입니다. 


            Typing("Red", "Battle!\n");
            //플레이어의 이름 의 공격!
            TypingWrite("white", $"Lv");
            TypingWrite("red", $"{MonsterData.MonsterList[input - 1].Level}");
            TypingWrite("white", $"{MonsterData.MonsterList[input - 1].Name}을(를) 맞췄습니다. [데미지 : "); //TypingWrite 함수 갱신되기 전에 사용
            int Player_baseAttack = Player.basePower;

            int Player_error = (int)Math.Ceiling(Player_baseAttack * 0.1); //공격력의 오차 설정
            int min = Player_baseAttack - Player_error; //최소 데미지
            int max = Player_baseAttack + Player_error; //최대 데미지
            Random random = new Random();
            int player_damage = random.Next(min, max + 1); // 오차에 따른 랜덤 데미지 설정하기
            TypingWrite("red", $"{player_damage}\n");
            TypingWrite("white", $"Lv");
            TypingWrite("red", $"{MonsterData.MonsterList[input - 1].Level}");
            TypingWrite("white", $"{MonsterData.MonsterList[input - 1].Name}\n");
            TypingWrite("white", "HP");
            TypingWrite("red", $"{MonsterData.MonsterList[input - 1].HP}");
            TypingWrite("white", "->");
            MonsterData.MonsterList[input - 1].HP -= player_damage; //데미지 계산
            if (MonsterData.MonsterList[input - 1].HP < 0) //체력이 마이너스가 되면 안되니까 음수로 되면 0으로 설정합니다.
            {

                MonsterData.MonsterList[input - 1].HP = 0;
            }
            if (MonsterData.MonsterList[input - 1].HP == 0) // 몬스터의 체력이 0이 된다면 죽이는 로직
            {
                TypingWrite("gray", " Dead\n");
                Monster_count--;
            }
            else //죽지 않았다면 남은 체력을 표시
            {
                TypingWrite("white", $" {MonsterData.MonsterList[input - 1].HP - player_damage}\n");






                Typing("red", "0.", "white", " 다음\n\n>>");

                WhatNum(0, 0);

                Player_turn = false; //플레이어의 턴이 종료됐으므로 false로 변경 후 몬스터의 턴 시작

                Console.Clear();

                Player_Turn_End();




            }
        }

        internal static void Monster_Phase() //몬스터 턴입니다.
        {
            Typing("Red", "Battle!\n");
            foreach (MonsterData.MonsterStat monster in MonsterData.MonsterList) // 몬스터 정보입니다.
            {
                if (monster.HP == 0) //몬스터가 죽었다면
                {

                    Typing("white", "Lv.", "red", $"{monster.Level}", "white", $"{monster.Name}은(는) 사망했기 때문에 공격 할 수 없다!");


                }
                else
                { //몬스터가 살아있다면


                    int Monster_baseAttack = monster.Attack;

                    int Monster_error = (int)Math.Ceiling(Monster_baseAttack * 0.1); //공격력의 오차 설정
                    int min = Monster_baseAttack - Monster_error; //최소 데미지
                    int max = Monster_baseAttack + Monster_error; //최대 데미지
                    Random random = new Random();
                    int Monster_damage = random.Next(min, max + 1); // 오차에 따른 랜덤 데미지 설정하기
                    Typing("white", "Lv.", "red", $"{monster.Level}", "white", $"{monster.Name}의 공격!");
                    TypingWrite("white", $"샌즈 을(를) 맞췃습니다."); //잠시 플레이어 이름 임의로 넣을게여
                    TypingWrite("white", "    [데미지 :  ");
                    TypingWrite("red", Monster_damage);
                    TypingWrite("white", "]\n\n");

                    Typing("white", "Lv.", "red", $"{Player.Level}", "white", $"샌즈"); //잠시 플레이어 이름 임의로 넣을게여
                    TypingWrite("white", "HP");
                    TypingWrite("red", $" {Player.CurrentHP} ");
                    TypingWrite("white", "-> ");

                    Player.CurrentHP -= Monster_damage; //데미지 입음
                    if (Player.CurrentHP < 0) //플레이어가 체력이 0이하가 됐을때
                    {
                        Player.CurrentHP = 0;
                        TypingWrite("red", $"{Player.CurrentHP}\n\n");

                        Typing("red", $"샌즈은(는) 쓰러졌다!\n눈앞이 캄캄해진다..."); //잠시 플레이어 이름 임의로 넣을게여
                        //마을로 돌아가는 로직


                    }
                    else //플레이어가 살아있을때
                    {
                        TypingWrite("red", $"{Player.CurrentHP}\n\n");

                        Typing("red", "0", "white", " 다음\n");
                        Typing("white", "대상을 선택해주세요.\n>>");
                        WhatNum(0, 0);
                        Console.Clear();
                    }





                }

            }
            Player_turn = true; //몬스터의 턴이 끝나면 플레이어의 턴을 실행합니다.
            My_Phase();


        }

        internal static void Player_Turn_End()
        {
            if (Player_turn == false && Monster_count != 0) //아 근데 저거 bool값 굳이 필요한가 싶기도 하고.. //몬스터가 살아있을때만 몬스터 페이즈로 넘어갑니다.
            {
                Monster_Phase(); //몬스터 페이즈 실행


            }
            else if (Player_turn == false && Monster_count == 0) //몬스터가 다 죽으면 실행합니다.
            {
                Typing("red", "Battle! - Result\n");
                Typing("green", "Vitory!\n");

                Typing("white", $"던전에서 몬스터 ", "red", $"{MonsterData.MonsterList.Count}", "white", "마리를 잡았습니다.");
                Typing("red", "0.", "white", " 다음");

                WhatNum(0, 0);
                Console.Clear();

                //마을로 돌아가는 로직


            }


        }//플레이어 턴이 끝났을때 실행되는 함수입니다.
    }
}