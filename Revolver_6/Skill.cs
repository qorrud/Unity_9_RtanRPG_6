using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Revolver_6.Data;


namespace Revolver_6
{
    internal class Skill
    {
        
        //메서드 //필드 //생성자..

        public class Skill_Info // 스킬 정보 

        {


            public string Skill_Name { get; set; } // 스킬 이름
            public string Skill_Description { get; set; } // 스킬 설명
            public double Damage { get; set; } //스킬 데미지 배율
            public int Use_MP { get; set; } //스킬 사용마나
            public int ClassType { get; set; } //사용 가능 직업
            public int TargetType { get; set; } //공격 타입 ex) 단일, 전체, 랜덤
            
            public int AttackTry {  get; set; } // 공격 횟수
            

        }

        public List<Skill_Info> SkillList = new List<Skill_Info>() //스킬 담을 리스트
     

        {
            

        /*
        none = 0,
        knight = 1,
        archer = 2,
        rogue = 4,
        magician = 8,
        all = 16,
        */
               new Skill_Info
               {
                   Skill_Name = "연속 공격",
                   Skill_Description = "빠른 속도로 2번 공격한다.",
                   Damage =  0.6,
                   Use_MP = 15,
                   ClassType = 16, 
                   TargetType = 1,
                   AttackTry = 2



               },

                new Skill_Info
               {
                   Skill_Name = "길로틴",
                   Skill_Description = "양손에 검을 쥐고 혼신의 힘을 모아 내려벤다.",
                   Damage =  1.6,
                   Use_MP = 30,
                   ClassType = 1, //전사만
                   TargetType = 1,
                   AttackTry = 1



               },
               new Skill_Info
               {
                   Skill_Name = "공간절단",
                   Skill_Description = "주위의 공간과 더불어 모든적을 찢어서 큰 데미지를 준다.",
                   Damage = 2,
                   Use_MP = 50,
                   ClassType = 1, //전사만
                   TargetType = MonsterData.MonsterList.Count,
                   AttackTry = 1



               },


                new Skill_Info
               {
                   Skill_Name = "폭풍의 시",
                   Skill_Description = "폭풍같은 속도로 적에게 화살을 퍼붓는다.",
                   Damage = 0.16,
                   Use_MP = 30,
                   ClassType = 2, //궁수만
                   TargetType = 1,
                   AttackTry = 10



               },

                new Skill_Info
               {
                   Skill_Name = "태풍의 시",
                   Skill_Description = "태풍같은 속도로 모든적에게 화살을 퍼부어 휩쓸어버린다.",
                   Damage = 2,
                   Use_MP = 50,
                   ClassType = 2, //궁수만
                   TargetType = MonsterData.MonsterList.Count,
                   AttackTry = 1



               },

                new Skill_Info
               {
                   Skill_Name = "댄싱 오브 퓨리",
                   Skill_Description = "그림자의 기운을 모아 주변을 그림자 처럼 빠르게 움직이며 베어낸다.",
                   Damage = 1.3,
                   Use_MP = 30,
                   ClassType = 4, //도적만
                   TargetType = 1,
                   AttackTry = 1



               },

                new Skill_Info
               {
                   Skill_Name = "레퀴엠",
                   Skill_Description = "빠르게 전방의 적들에게 치명적인 일격을 날려 그들의 생명을 거둔다.",
                   Damage = 2,
                   Use_MP = 50,
                   ClassType = 4, //도적만
                   TargetType = MonsterData.MonsterList.Count,
                   AttackTry = 1



               },

                new Skill_Info
               {
                   Skill_Name = "천벌",
                   Skill_Description = "낙뢰를 떨어뜨려 적에게 피해를 입힌다.",
                   Damage = 1.6,
                   Use_MP = 30,
                   ClassType = 8, //마법사만
                   TargetType = 1,
                   AttackTry = 1



               },
                new Skill_Info
               {
                   Skill_Name = "종말의 날",
                   Skill_Description = "거대한 운석을 떨어뜨려 모든적을 초토화 시킨다.",
                   Damage = 2,
                   Use_MP = 50,
                   ClassType = 8, //마법사만
                   TargetType = MonsterData.MonsterList.Count,
                   AttackTry = 1



               },









        };

        public List<Skill_Info> MySkillList = new List<Skill_Info>() //직업에 맞는 스킬 담을 리스트

        { 
        
        }; 
        
        public void MySkill()
        {
            if (Player.Job is ClassType.knight) 
            {
                for (int i = 0; SkillList.Count > i; i++)

                {
                    if (SkillList[i].ClassType == 1 || SkillList[i].ClassType == 16) // 공용 스킬과 전사 스킬만
                    {
                        MySkillList.Add(SkillList[i]);

                    }
                }
            }

           else if (Player.Job is ClassType.archer) 
            {
                for (int i = 0; SkillList.Count > i; i++)

                {
                    if (SkillList[i].ClassType == 2 || SkillList[i].ClassType == 16) // 공용 스킬과 궁수 스킬만
                    {
                        MySkillList.Add(SkillList[i]);

                    }
                }
            }

            else if (Player.Job is ClassType.rogue)
            {
                for (int i = 0; SkillList.Count > i; i++)

                {
                    if (SkillList[i].ClassType == 4 || SkillList[i].ClassType == 16) // 공용 스킬과 도적 스킬만
                    {
                        MySkillList.Add(SkillList[i]);

                    }
                }
            }

            else if (Player.Job is ClassType.magician)
            {
                for (int i = 0; SkillList.Count > i; i++)

                {
                    if (SkillList[i].ClassType == 8 || SkillList[i].ClassType == 16) // 공용 스킬과 법사 스킬만
                    {
                        MySkillList.Add(SkillList[i]);

                    }
                }
            }

        }
        
            
            
           
           



    }
}
