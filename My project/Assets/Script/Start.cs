namespace Script
{
    public class Start
    {
        private int _sessionID;
        
        public Start(int id = -1)
        {
            _sessionID = id;
        }
        
        
        private void LoadGame(float money, int days)
        {
            Game.GetInstance().LoadGameData(money, days);
        }

        private void NewGame() => 
            Game.GetInstance();
    }
}