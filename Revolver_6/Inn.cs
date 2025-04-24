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
        public static void InnIntro()
        {
            // Helper.Typing("magenta", monster[i].Level, "", $" {monster[i].Name}  HP ", "magenta", "monster[i].HP / {monster[i].MaxHP}",0);
            // Helper.Typing("green", "당신은 포근한 여관에 들어섰습니다...");
            // Helper.Typing("green", "모닥불이 조용히 타오르고, 벽난로 위에는 사슴 박제가 걸려 있습니다.");

            // Thread.Sleep(1000);

            // Helper.Typing("cyan", "\"어서 오세요, 여행자님.\"");
            // Helper.Typing("cyan", "당신을 맞이하는 건 푸근한 인상의 여관 주인입니다.");
            // Helper.Typing("cyan", "\"긴 모험에 지치셨을 테니, 편히 쉬어가세요.\"");

            // Thread.Sleep(1000);

            // Helper.Typing("white", "\n■ 객실 종류 안내 ■"); // 가격 책정도 해야함
            // Helper.Typing("white", "1. 하급 객실");
            // Helper.Typing("white", "2. 중급 객실");
            // Helper.Typing("white", "3. 상급 객실");
            // Helper.Typing("white", "4. 최상급 객실");

            // Thread.Sleep(1000);

            // Helper.Typing("white", "\n[하급 객실] : 매우 협소하지만 최소한의 쉼을 제공합니다. 피로를", "green", "아주 조금", "white", "풉니다.");
            // Helper.Typing("white", "[중급 객실] : 적당한 크기의 방. 따뜻한 잠자리가 제공됩니다. 피로를", "green", "어느정도", "white", "풉니다.");
            // Helper.Typing("white", "[상급 객실] : 훌륭한 침구와 넓은 방. 피로가 빠르게 풀립니다. 피로를", "green", "상당히", "white", "풉니다.");
            // Helper.Typing("white", "[최상급 객실] : 고급 침대와 아로마향 가득한 룸서비스. 피로를", "green", "완벽하게", "white", "풉니다.");

            Helper.Typing("gray", "\n※ 객실을 선택하려면 숫자를 입력하세요.");
            InnSelect();
        }

        private static void InnSelect()
        {
            int input = Helper.WhatNum(1, 5);

            switch (input)
            {
                case 1: // 하급 객실
                    Helper.Typing("cyan", "좁고 딱딱한 침대에 몸을 누입니다...");
                    Helper.Typing("cyan", "당신은 몇 번을 뒤척이다 간신히 잠에 듭니다.");
                    Helper.Typing("gray", "[하급 객실] 체력 25% 회복.");
                    ExtraEffect.UseEffect("heal%", 25);
                    GameManager.Instance.TurnEnd();
                    break;


                case 2: // 중급 객실
                    Helper.Typing("cyan", "따뜻한 이불 속에 들어가자, 피로가 스르르 녹아내립니다.");
                    Helper.Typing("cyan", "잔잔히 타오르는 모닥불 소리를 들으며 어느새 잠에 듭니다.");
                    Helper.Typing("gray", "[중급 객실] 체력 50% 회복.");
                    ExtraEffect.UseEffect("heal%", 50);
                    GameManager.Instance.TurnEnd();
                    break;


                case 3: // 상급 객실
                    Helper.Typing("cyan", "푹신한 침대에 누우니, 몸이 천천히 이완됩니다...");
                    Helper.Typing("cyan", "창문 너머로 달빛이 잔잔히 스며들고, 마음마저 편안해집니다.");
                    Helper.Typing("gray", "[상급 객실] 체력 75% 회복.");
                    ExtraEffect.UseEffect("heal%", 75);
                    GameManager.Instance.TurnEnd();
                    break;


                case 4: // 최상급 객실
                    Helper.Typing("cyan", "정갈한 침대, 은은한 아로마 향, 고요한 조명 속에서 깊은 잠에 빠져듭니다.");
                    Helper.Typing("cyan", "이렇게 푹 쉰게 얼마만인지 기억조차 나지 않습니다, 피로가 완전히 사라졌습니다.");
                    Helper.Typing("gray", "[최상급 객실] 체력 100% 회복.");
                    ExtraEffect.UseEffect("heal%", 100);
                    GameManager.Instance.TurnEnd();
                    break;

                case 5:
                    Helper.Typing("gray", "거렁뱅이는 꺼져!!"); // 예외 처리
                    
                    break;
            }

        }

    }
}

