using static Revolver_6.Data;

namespace Revolver_6
{
    internal class GameManager
    {
        public void NewPlayer(string name, ClassType Job) // 플레이어 객체를을 초기화 하는 함수
        {
            Player = new PlayerStats(name, Job);
        }

        public void NewMonster() // 몬스터 객체를 초기화 하는 함수
        {           
            monster = MonsterData.MonsterFactory.MonsterSpwan();
        }

        public void NewInventory() // 인벤토리 객체를 초기화 하는 함수
        {
            Inventory = new List<Item.ItemInfo>();
        }



    }
}