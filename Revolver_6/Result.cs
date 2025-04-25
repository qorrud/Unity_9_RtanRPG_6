using System.Threading;
using static Revolver_6.Helper;
using static Revolver_6.Data;
namespace Revolver_6
{
    internal static class Result
    {


        internal static void Player_Turn_End(bool Player_turn, int Monster_count)
        {

            if (!Player_turn && Monster_count != 0)  //몬스터가 살아있을때만 몬스터 페이즈로 넘어갑니다.
            {
                Battle.Monster_Phase(); //몬스터 페이즈 실행


            }
            else if (Player_turn == false && Monster_count == 0) //몬스터가 다 죽으면 실행합니다.
            {
                Typing("red", "Battle! - Result\n");
                Typing("green", "Vitory!\n");

                Typing("white", $"던전에서 몬스터 ", "red", $"{monster.Length}", "white", "마리를 잡았습니다.");
                ExtraEffect.GainExp();
                ExtraEffect.LevelUp();
                ExtraEffect.GainGold();
                Typing("red", "1.", "white", " 다음 전투", "", "2. 돌아가기");

                int input = WhatNum(1, 2);
                int value = ExtraEffect.MonsterValue();

                //마을로 돌아가는 로직

                for (int i = 0; i < 3; i++)
                {
                    Console.Clear();
                    Typing("",".....",200);
                }

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        monster = MonsterData.MonsterFactory.MonsterSpawn();
                        Battle.My_Phase();
                        break;

                    case 2:
                        Console.Clear();
                        Typing("white", "던전 클리어!\n마을로 귀환합니다");
                        Typing("",".....",500);
                        GameManager.Instance.TurnEnd();
                        break;
                }




            }


        }//플레이어 턴이 끝났을때 실행되는 함수입니다.
    }
}