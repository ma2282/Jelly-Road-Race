using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class ValuesManager : Singleton<ValuesManager>
    {
        private int _coins;
        private int _scoreNow;
        private int _recordScore;

        public void AddCoins(int coins)
        {
            _coins += coins;
            UIManager.Instance.ChangeCoins(_coins);
        }

        public void AddScore(int score)
        {
            _scoreNow += score;
            
            _recordScore = Mathf.Max(_scoreNow, _recordScore);
            
            UIManager.Instance.ChangeScore(_scoreNow);
        }

        public void SetCoins(int coins)
        {
            _coins = coins;
            
            UIManager.Instance.ChangeCoins(_coins);
        }

        public void SetRecordScore(int recordScore)
        {
            _recordScore = recordScore;
            
            UIManager.Instance.ChangeRecordScore(_recordScore);
        }

        public void Save()
        {
            SaveData data = new (){Coins = _coins, RecordScore = _recordScore};

            SaveLoadSystem.SaveData(data);
        }
    }
}