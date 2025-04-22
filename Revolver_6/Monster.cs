namespace Revolver_6
{
    internal class MonsterData //몬스터 정보에 관한 데이터베이스
    {
        public class MonsterStat // 몬스터의 스태이터스, 골드와 경험치는 현재 미정
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int Attack { get; set; }
            public int HP { get; set; }
            public int Gold { get; set; }
            public int Exp { get; set; }


            public MonsterStat()
            {
                Name = "오류";
                Level = -1;
                Attack = 0;
                HP = 1;
                Exp = 1;

            }
            public MonsterStat(string name, int level, int hp, int attack, int gold, int exp) //MonsterStat 객체를 만들 때 필요한 생성자
            {                                                                                  //그 객체를 만들 때 안에 들어갈 값을 한 번에 설정하기 위함
                Name = name;                                                                    // 이 생성자가 없다면 32번째줄에 코드가 하나씩 입력해야해서 길어짐
                Level = level;
                Attack = attack;
                HP = hp;
                Gold = gold;
                Exp = exp;
            }

            public void Display()
            {
                Console.Write($"Lv.{Level} {Name}   HP{HP}");
            }
        }

            public static List<MonsterData.MonsterStat> MonsterList = new List<MonsterData.MonsterStat>
        {                  //name,      lv, hp, atk, gold, exp
            new MonsterData.MonsterStat( "미니언"   , 2 , 6 , 15 , 0 ,0),
            new MonsterData.MonsterStat("대포 미니언", 5, 15, 25, 0, 0),
            new MonsterData.MonsterStat("공허충"    , 3, 10, 10, 0, 0),
            new MonsterData.MonsterStat("공허의 전령", 8, 20, 20, 0, 0 )
        };
            public class MonsterFactory
            {


            }

        
    }
}