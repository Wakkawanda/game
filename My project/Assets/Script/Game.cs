using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace Script
{
    public class Game : MonoBehaviour
    {
        private static Game _instance;
        
        private float _accumulatedMoney;
        private int _livedDays;
        
        protected Game()
        {
            // Инициализируються базовые значения
            _accumulatedMoney = 0; 
            _livedDays = 0;
        }

        // Методы работы с полями
        public float GetAccumulatedMoney() => _accumulatedMoney;
        public float SetAccumulatedMoney(float money) => _accumulatedMoney += money;
        
        public float GetLivedDays() => _livedDays;
        public float SetLivedDays(int days) => _livedDays += days;
        
        
        // Инициализация получения класса
        public static Game GetInstance()
        {
            if (_instance == null)
                _instance = new Game();
            
            return _instance;
        }

        public void LoadGameData(float money, int days)
        {
            _accumulatedMoney = money;
            _livedDays = days;
            // TODO Логирование что класс GAME обновлён !!!
        }
    }
}