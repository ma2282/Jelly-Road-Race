using System.Collections;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class ValuesManager : Singleton<ValuesManager>
    {
        [SerializeField] private int _scoreRate = 1;
        
        private int _coins;
        private int _scoreNow;
        private int _recordScore;

        private CoroutineObject _addingScoreCoroutine;
        
        private void Start()
        {
            _addingScoreCoroutine = new CoroutineObject(this, AddingScoreCoroutine);
        }

        private IEnumerator AddingScoreCoroutine()
        {
            while (true)
            {
                AddScore(_scoreRate);
                yield return new WaitForSeconds(1f);
            }
        }
        
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

        public void ResetScore()
        {
            _scoreNow = 0;

            UIManager.Instance.ChangeScore(_scoreNow);
        }

        public void StartScore()
        {
            _addingScoreCoroutine.Start();
        }

        public void StopScore()
        {
            _addingScoreCoroutine.Stop();
        }
    }
}