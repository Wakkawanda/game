using UnityEngine;

namespace Script
{
    public class Game
    {
        private static Game _instance;
        private bool _isInitialized = false;
        
        
        private float _accumulatedMoney;
        private int _livedDays;

        public float GetAccumulatedMoney() => _accumulatedMoney;
        
        public float GetLivedDays() => _livedDays;


        protected Game()
        {
            _accumulatedMoney = 0;
            _livedDays = 0;
        }

        public void Initialize(float money, int days)
        {
            if (!_isInitialized)
            {
                _accumulatedMoney = money;
                _livedDays = days;
            }
            else
            {
                // TODO Добавить логирование на инициализацию обекта.
            }
        } 

        public static Game GetInstance()
        {
            if (_instance == null)
                _instance = new Game();
            
            return _instance;
        }
    }
}