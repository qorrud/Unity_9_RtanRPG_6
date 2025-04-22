namespace Revolver_6
{
    internal class Battle
    {

        //    - 공격을 선택하면 몬스터 앞에 숫자가 표시됩니다.
        //    - 일치하는 몬스터를 선택하지 않았다면(예제에서 1~3이외 선택시)
        //    - **잘못된 입력입니다** 출력
        //    - 이미 죽은 몬스터를 공격했다면
        //    - **잘못된 입력입니다** 출력
        //    - 몬스터를 알맞게 선택했다면
        //    - 해당 몬스터 공격
        //           최종 공격력 9 ~ 11 랜덤 값
        //    - 오차가 소수점이라면 올림 처리합니다.
        //          - 공격력 5
        //          오차 0.5 → 1  (올림처리)
        //          최종 공격력 4 ~ 6  랜덤 값
        //    - 몬스터가 죽었다면 체력 대신 Dead 으로 표시됩니다.
        //    - 몬스터가 죽었다면 해당 몬스터에 텍스트는 전부 어두운 색으로 표시합니다.
        static bool Player_turn = true; //플레이어의 턴은 true 몬스터의 턴은 false로 할게요
        int rage = 0; // 쓸 지는 모르겠지만 광폭화 스택입니다. 플레이어, 몬스터의 턴이 끝나면 1씩 증가하고 일정 수치 이상이 된다면 몬스터의 스탯이 뻥튀기 되는 거 넣어볼 생각인데 나중에..

        internal static void My_Phase() //플레이어의 턴일때 실행되는 함수입니다. 플레이어의 턴이 끝나면  turn 은 false로 변경해서 적의 턴으로 넘어갑니다.
        {
            //Spawn_Random_Monster() 랜덤 몬스터 소환 로직 넣을껍니다.
            int monster_index = 1; //몬스터 출현시 붙일 번호입니다. 1번부터 선언

            foreach (var monster in MonsterData.MonsterList)
            {
                Console.WriteLine($"{monster_index}. Lv.{monster.Level} {monster.Name}  HP {monster.HP}");
                monster_index++;

            }
            Console.WriteLine("Battle!");
            int Monster_Count = Monster.length //나중에 생성된 몬스터들이 배열이라면 배열의 길이로 몬스터 몇 마리인지 측정
            for (int i = 0; i < Monster_Count; i++) //몬스터의 수 만큼 몬스터 정보를 출력합니다.
            {

                Console.WriteLine($"Lv.{Monster.} {Monster.name}  HP {Monter.HP}");
            
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"[내정보]\nLv.{PlayerStats.}  {Profile.Name} ({Profile.Class})\nHP {Profile.MaxHP}/{Profile.NowHP}\n");
            //플레이어의 정보 출력합니다.

            Console.WriteLine("1. 공격\n원하시는 행동을 입력해주세요.\n>>");
            

        }
    }
}