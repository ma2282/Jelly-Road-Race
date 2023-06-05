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
        [SerializeField] private float timeRate = 0.5f;
        [SerializeField] private float maxTimeScale = 2f;

        private int _coins;
        private int _scoreNow;
        private int _recordScore;

        private CoroutineObject _addingScoreCoroutine;
        private CoroutineObject _addingTimeScaleCoroutine;

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
            _addingScoreCoroutine = new CoroutineObject(this, AddingScoreCoroutine);
            _addingTimeScaleCoroutine = new CoroutineObject(this, AddingTimeScaleCoroutine);
        }

        private IEnumerator AddingScoreCoroutine()
        {
            while (true)
            {
                AddScore(scoreRate);
                yield return new WaitForSeconds(1f);
            }
        }

        private IEnumerator AddingTimeScaleCoroutine()
        {
            while (true)
            {
                AddTimeScale();
                yield return new WaitForSeconds(1f);
            }
        }

        private void AddTimeScale()
        {
            Time.timeScale = Mathf.Min(maxTimeScale, Time.timeScale + timeRate / Time.timeScale);
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

            Time.timeScale = 1f;

            UIManager.Instance.ChangeScore(_scoreNow);
        }

        public void StartScore()
        {
            _addingScoreCoroutine.Start();
            _addingTimeScaleCoroutine.Start();
        }

        public void StopScore()
        {
            _addingScoreCoroutine.Stop();
            _addingTimeScaleCoroutine.Stop();
        }
    }
}