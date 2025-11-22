namespace Script
{
    public class Start
    {
        private int _sessionID;
        
        public Start(int id = -1)
        {
            _sessionID = id;
        }
        
        
        public void LoadGame(float money, int days)
        {
            Game.GetInstance().LoadGameData(money, days);
        }

        public void NewGame() => 
            Game.GetInstance();
    }
}