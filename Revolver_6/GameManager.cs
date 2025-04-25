using static Revolver_6.Data;

namespace Revolver_6
{
    internal class GameManager
    {
        public Title title = new Title();
        private static GameManager instance;
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new GameManager();
                return instance;
            }
        }

        private GameManager() {}

        
        public void NewPlayer(string name, ClassType Job) // 플레이어 객체를을 초기화 하는 함수
        {
            Player = new PlayerInfo(name, Job);
        }

        public void NewMonster() // 몬스터 객체를 초기화 하는 함수
        {           
            monster = MonsterData.MonsterFactory.MonsterSpawn();
        }

        public void NewInventory() // 인벤토리 객체를 초기화 하는 함수
        {
            Inventory = new List<ItemInfo>();
        }

        public void TurnEnd()
        {
            Difficulty = 0;
            Helper.Typing("", "다음날이 되었습니다.\n현재 난이도 : ", "yellow", Difficulty);
            title.GameHome();
        }
        public int Difficulty = 1;
        public bool gaemOver = false;
    }
}