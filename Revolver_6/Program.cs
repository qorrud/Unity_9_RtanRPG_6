namespace Revolver_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager();
            Title title = new Title();

            string PlayerName = "";
            ClassType PlayerJob = ClassType.knight;
            bool gameOver = false;
        
            title.GameStart();
            
            PlayerName = title.ReadName();
            PlayerJob = title.ReadJob();

            game.NewPlayer(PlayerName, PlayerJob);
            while (!gameOver) // 게임시작
            {
                

                title.GameHome();
                //메인화면
                //이름선택
                //직업선택
                
                
                
            }
        }
    }
}
