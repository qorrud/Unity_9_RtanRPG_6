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

            public void Display(MonsterStat[] monster)
            {
                for (int i = 0; i < monster.Length; i++)
                {
                    Helper.TypingWrite("blue", i+1,0);
                    Helper.TypingWrite("", " Lv.",0);
                    Helper.Typing("magenta", monster[i].Level, "", $" {monster[i].Name}  HP ", "magenta", monster[i].HP,0);
                    Thread.Sleep(200);
                }
            }
        }

        public static Dictionary<int, MonsterStat> MonsterList = new Dictionary<int, MonsterStat>()
        {                  //           name,      lv, hp, atk, gold, exp, index
            {1, new MonsterData.MonsterStat( "미니언"   , 2, 6, 15, 0, 0, 1)},
            {2, new MonsterData.MonsterStat("대포 미니언", 5, 15, 25, 0, 0, 2)},
            {3, new MonsterData.MonsterStat("공허충"    , 3, 10, 10, 0, 0, 3)},
            {4, new MonsterData.MonsterStat("공허의 전령", 8, 20, 20, 0, 0, 4)},
        };
        public class MonsterFactory
        {


            public static int[] RandomSpawn()
            {
                Random random = new Random();
                int[] MonsterNumber = new int[random.Next(1, 5)];
                for (int i = 0; i < MonsterNumber.Length; i++)
                {
                    MonsterNumber[i] = random.Next(1, 5);
                }
                return MonsterNumber;
            }
            public static MonsterStat[] MonsterSpwan()
            {
                int[] a = RandomSpawn();
                MonsterStat[] Dummy = new MonsterStat[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    Dummy[i] = new MonsterStat();
                    Dummy[i].Name = MonsterList[a[i]].Name;
                    Dummy[i].Level = MonsterList[a[i]].Level;
                    Dummy[i].Attack = MonsterList[a[i]].Attack;
                    Dummy[i].HP = MonsterList[a[i]].HP;
                    Dummy[i].Gold = MonsterList[a[i]].Gold;
                    Dummy[i].Exp = MonsterList[a[i]].Exp;
                    Dummy[i].Index = MonsterList[a[i]].Index;
                }
                return Dummy;
            }
        }
    }
}