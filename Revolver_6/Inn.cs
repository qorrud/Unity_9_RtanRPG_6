using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Revolver_6.Helper;

namespace Revolver_6
{
    internal class Inn
    {
    public void InnIntro()
        {
            // Helper.Typing("magenta", monster[i].Level, "", $" {monster[i].Name}  HP ", "magenta", "monster[i].HP / {monster[i].MaxHP}",0);
            Helper.Typing("green", "당신은 포근한 여관에 들어섰습니다...");
            Helper.Typing("green", "모닥불이 조용히 타오르고, 벽난로 위에는 사슴 박제가 걸려 있습니다.");

            Thread.Sleep(1000);

            Helper.Typing("cyan", "\"어서 오세요, 여행자님.\"");
            Helper.Typing("cyan", "당신을 맞이하는 건 푸근한 인상의 여관 주인입니다.");
            Helper.Typing("cyan", "\"긴 모험에 지치셨을 테니, 편히 쉬어가세요.\"");

            Thread.Sleep(1000);

            Helper.Typing("white", "\n■ 객실 종류 안내 ■"); // 가격 책정도 해야함
            Helper.Typing("white", "1. 하급 객실");
            Helper.Typing("white", "2. 중급 객실");
            Helper.Typing("white", "3. 상급 객실");
            Helper.Typing("white", "4. 최상급 객실");

            Thread.Sleep(1000);

            Helper.Typing("white", "\n[하급 객실] : 매우 협소하지만 최소한의 쉼을 제공합니다. 피로를","green", "아주 조금","white","풉니다.");
            Helper.Typing("white", "[중급 객실] : 적당한 크기의 방. 따뜻한 담요와 식사가 제공됩니다. 피로를","green", "어느정도","white","풉니다.");
            Helper.Typing("white", "[상급 객실] : 깔끔한 침구, 창가 자리. 피로가 빠르게 풀립니다. 피로를","green", "상당히","white","풉니다.");
            Helper.Typing("white", "[최상급 객실] : 고급 침대와 아로마향 가득한 룸서비스. 피로를","green", "완벽하게","white","풉니다.");

            Helper.Typing("gray", "\n※ 객실을 선택하려면 숫자를 입력하세요.");

        }

        public int InnSelect()
        {
            int input = Helper.WhatNum(1,4);

            switch(input)
            {
                case 1: //하급 객실
                    return 25; 
                case 2: // 중급 객실
                    //HealCount(50);
                    return 50;
                case 3: // 상급 객실
                    //HealCount(75);
                    return 75;
                case 4: // 최상급 객실
                    //HealCount(100);
                    return 100;
                default:
                    return 0;
            }
        }

    }
    }

