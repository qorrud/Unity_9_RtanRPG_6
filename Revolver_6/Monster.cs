namespace Revolver_6
{
    internal class MonsterData //몬스터 정보에 관한 데이터베이스
    {
        public class MonsterStat // 몬스터의 스태이터스, 골드와 경험치는 현재 미정
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int Attack { get; set; }
            public int MaxHP { get; set; }
            public int HP { get; set; }
            public int Gold { get; set; }
            public int Exp { get; set; }
            public int Index { get; set; }
            public MonsterStat()
            {
                Name = "오류";
                Level = 0;
                Attack = 0;
                MaxHP = 0;
                HP = 0;
                Gold = 0;
                Exp = 0;
                Index = 0;
            }
            public MonsterStat(string name, int level, int max_hp, int hp, int attack, int gold, int exp, int index) //MonsterStat 객체를 만들 때 필요한 생성자
            {                                                                                  //그 객체를 만들 때 안에 들어갈 값을 한 번에 설정하기 위함
                Name = name;                                                                    // 이 생성자가 없다면 32번째줄에 코드가 하나씩 입력해야해서 길어짐
                Level = level;
                Attack = attack;
                MaxHP = max_hp;
                HP = hp;
                Gold = gold;
                Exp = exp;
                Index = index;
            }
            public static void Display(MonsterStat[] monster)
            {
                for (int i = 0; i < monster.Length; i++)
                {
                    Helper.TypingWrite("blue", $"{i + 1} ", 0);
                    Helper.TypingWrite("", "Lv. ", 0);
                    Helper.TypingWrite("magenta", $"{monster[i].Level} ", 0);
                    Helper.TypingWrite("", $"{monster[i].Name}  ", 0);
                    if (monster[i].HP > 0)
                    {
                        Helper.TypingWrite("", "HP ", 0);
                        Helper.TypingWrite("magenta", $"{monster[i].HP} / {monster[i].MaxHP}", 0);
                    }
                    else
                    {
                        Helper.TypingWrite("gray", "Dead", 0);
                    }
                    Console.WriteLine(); // 줄바꿈
                    Thread.Sleep(150);
                }
            }

        }
        public static Dictionary<int, MonsterStat> MonsterList = new Dictionary<int, MonsterStat>()
        {                  //                name,      lv, maxhp, hp, atk, gold, exp, index
            {1, new MonsterData.MonsterStat("미니언"     , 2, 6, 6, 8, 10, 5, 1)},
            {2, new MonsterData.MonsterStat("대포 미니언" , 4, 12, 12, 10, 20, 10, 2)},
            {3, new MonsterData.MonsterStat("공허충"     , 5, 10, 10, 12, 30, 15, 3)},
            {4, new MonsterData.MonsterStat("어스름 늑대" , 7, 20, 20, 20, 40, 20, 4)},
            {5, new MonsterData.MonsterStat("칼날부리"    , 7, 20, 20, 20, 40, 20, 5)},
            {6, new MonsterData.MonsterStat("심술 두꺼비" , 8, 25, 25, 25, 60, 30, 6)},
            {7, new MonsterData.MonsterStat("공허의 전령" , 9, 30, 30, 30, 70, 40, 7)},
            {8, new MonsterData.MonsterStat("바론 남작"   , 10, 35, 35, 40, 80, 50, 8)},
        };
        public class MonsterFactory
        {
            public static int[] RandomSpawn()
            {
                Random random = new Random();

                int monsterCount = random.Next(1,5);

                int stage = GameManager.Instance.Difficulty / 3;
    
                int[] MonsterNumber = new int[monsterCount];
                for (int i = 0; i < MonsterNumber.Length; i++)
                {
                    switch(stage)
                    {
                        case 0:
                         MonsterNumber[i] = random.Next(1, 3);
                         break;
                          case 1:
                         MonsterNumber[i] = random.Next(1, 5);
                         break;
                          case 2:
                         MonsterNumber[i] = random.Next(1, 7);
                         break;
                          case 3:
                         MonsterNumber[i] = random.Next(3, 7);
                         break;
                          case 4:
                         MonsterNumber[i] = random.Next(4, 7);
                         break;
                          case 5:
                         MonsterNumber[i] = random.Next(4, 8);
                         break;
                          case 6:
                         MonsterNumber[i] = random.Next(5, 8);
                         break;
                    }
                   
                }
                return MonsterNumber;
            }
            public static MonsterStat[] MonsterSpawn()
            {
                int[] a = RandomSpawn();
                MonsterStat[] Dummy = new MonsterStat[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    Dummy[i] = new MonsterStat();
                    Dummy[i].Name = MonsterList[a[i]].Name;
                    Dummy[i].Level = MonsterList[a[i]].Level;
                    Dummy[i].Attack = MonsterList[a[i]].Attack + (GameManager.Instance.Difficulty % 3);
                    Dummy[i].MaxHP = MonsterList[a[i]].MaxHP + 2 * (GameManager.Instance.Difficulty % 3);
                    Dummy[i].HP = MonsterList[a[i]].HP + 2 * (GameManager.Instance.Difficulty % 3);
                    Dummy[i].Gold = MonsterList[a[i]].Gold + (GameManager.Instance.Difficulty % 3);
                    Dummy[i].Exp = MonsterList[a[i]].Exp + (GameManager.Instance.Difficulty % 3);
                    Dummy[i].Index = MonsterList[a[i]].Index;
                }
                return Dummy;
            }
        }
    }
}