using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class ValuesManager : Singleton<ValuesManager>
    {
        [SerializeField] private int scoreRate = 1;

        private int _coins;
        private int _scoreNow;
        private int _recordScore;

        private CoroutineObject _addingScoreCoroutine;
        

        public int Coins
        {
            get => _coins;
            set
            {
                _coins = value;
                UIManager.Instance.ChangeCoins(value);
            }
        }

        private void Start()
        {
            if (_addingScoreCoroutine == null)
                Initialize();
        }

        private void Initialize()
        {
            _addingScoreCoroutine = new CoroutineObject(this, AddingScoreCoroutine);
        }

        private IEnumerator AddingScoreCoroutine()
        {
            while (true)
            {
                AddScore(scoreRate);
                yield return new WaitForSeconds(1f);
            }
        }

        public void AddScore(int score)
        {
            _scoreNow += score;
            
            _recordScore = Mathf.Max(_scoreNow, _recordScore);
            
            UIManager.Instance.ChangeScore(_scoreNow);
        }


        public void SetCoins(int coins)
        {
            Coins = coins;
            
            UIManager.Instance.ChangeCoins(Coins);
        }

        public void SetRecordScore(int recordScore)
        {
            _recordScore = recordScore;
            
            UIManager.Instance.ChangeRecordScore(_recordScore);
        }

        public SaveData Save()
        {
            SaveData data = new (){Coins = Coins, RecordScore = _recordScore};
            
            return data;
        }

        public void RestoreDefaults()
        {
            _scoreNow = 0;

            UIManager.Instance.ChangeScore(_scoreNow);
        }

        public void StartScore()
        {
            if (_addingScoreCoroutine == null)
                Initialize();
            
            _addingScoreCoroutine.Start();
        }

        public void StopScore()
        {
            if (_addingScoreCoroutine == null)
                Initialize();
            
            _addingScoreCoroutine.Stop();
            UIManager.Instance.ChangeRecordScore(_recordScore);
        }
    }
}