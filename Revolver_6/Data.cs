using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolver_6
{
    internal class Data
    {
        public static PlayerStats Player = new PlayerStats();
         public static List<MonsterData.MonsterStat> MonsterList = new List<MonsterData.MonsterStat>
        {                  //name,      lv, hp, atk, gold, exp
            new MonsterData.MonsterStat( "미니언"   , 2 , 6 , 15 , 0 , 0),
            new MonsterData.MonsterStat("대포 미니언", 5, 15, 25, 0, 0),
            new MonsterData.MonsterStat("공허충"    , 3, 10, 10, 0, 0),
            new MonsterData.MonsterStat("공허의 전령", 8, 20, 20, 0, 0 )
        };
        
    }
}
