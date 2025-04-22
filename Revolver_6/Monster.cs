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

            public int Index { get; set; }


            public MonsterStat()
            {
                Name = "오류";
                Level = 0;
                Attack = 0;
                HP = 0;
                Gold = 0;
                Exp = 0;
                Index = 0;

            }
            public MonsterStat(string name, int level, int hp, int attack, int gold, int exp, int index) //MonsterStat 객체를 만들 때 필요한 생성자
            {                                                                                  //그 객체를 만들 때 안에 들어갈 값을 한 번에 설정하기 위함
                Name = name;                                                                    // 이 생성자가 없다면 32번째줄에 코드가 하나씩 입력해야해서 길어짐
                Level = level;
                Attack = attack;
                HP = hp;
                Gold = gold;
                Exp = exp;
                Index = index;
            }

            public void Display()
            {
                Console.Write($"Lv.{Level} {Name}   HP{HP}");
            }
        }

        public static List<MonsterData.MonsterStat> MonsterList = new List<MonsterData.MonsterStat>
        {                  //           name,      lv, hp, atk, gold, exp, index
            new MonsterData.MonsterStat( "미니언"   , 2, 6, 15, 0, 0, 1),
            new MonsterData.MonsterStat("대포 미니언", 5, 15, 25, 0, 0, 2),
            new MonsterData.MonsterStat("공허충"    , 3, 10, 10, 0, 0, 3),
            new MonsterData.MonsterStat("공허의 전령", 8, 20, 20, 0, 0, 4),
        };
        public class MonsterFactory
        {
            Random random = new Random();
            int[] MonsterNumber = new int[4]; // 일단 몬스터 수는 4자리로 고정

            public void RandomSpawn()
            {
                for (int i = 0; i < 3; i++)
                {
                    MonsterNumber[i] = random.Next(1, 4);
                }
            }
            List<MonsterStat> spawnMonster = new List<MonsterStat>();
            public void MonsterSpwan()
            {
                for (int i = 0; i < 4; i++)
                {
                    int index = MonsterNumber[i];
                    MonsterStat SpawnedMonster = MonsterList.Find(m => m.Index == index);
                    MonsterStat monster = new MonsterStat(SpawnedMonster);
                    spawnMonster.Add(monster);
                }


        }
        }


    }
}