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
                Typing("red", "0.", "white", " 다음");

                WhatNum(0, 0);


                //마을로 돌아가는 로직
                Typing("white", "던전 클리어!\n 마을로 귀환합니다");
                for (int i = 0; i < 3; i++)
                {
                    Typing("white", ".");
                    Thread.Sleep(400);

                }
                Title title = new Title();
                Console.Clear();
                title.GameHome();

            }


        }//플레이어 턴이 끝났을때 실행되는 함수입니다.
    }
}