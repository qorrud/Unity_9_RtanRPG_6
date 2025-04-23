namespace Revolver_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string PlayerName = "";
            ClassType PlayerJob = ClassType.knight;
            bool gameOver = false;
        
            GameManager.Instance.title.GameStart();
            
            PlayerName = GameManager.Instance.title.ReadName();
            PlayerJob = GameManager.Instance.title.ReadJob();

            GameManager.Instance.NewPlayer(PlayerName, PlayerJob);
            while (!GameManager.Instance.gaemOver) // 게임시작
            {
                

                GameManager.Instance.TurnEnd();
                //메인화면
                //이름선택
                //직업선택
                
                
                
            }
        }
    }
}
