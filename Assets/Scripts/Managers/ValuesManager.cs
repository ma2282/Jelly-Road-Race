using System.Collections;
using System.Collections.Generic;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class ValuesManager : Singleton<ValuesManager>
    {
        [SerializeField] private int scoreRate = 1;
        [SerializeField] private float timeRate = 0.5f;
        [SerializeField] private float maxTimeScale = 2f;
        [SerializeField] private SkinHandler skinHandler;
        
        private int _coins;
        private int _scoreNow;
        private int _recordScore;
        private List<SkinType> _skins;
        private SkinType _skinNow;

        private CoroutineObject _addingScoreCoroutine;
        private CoroutineObject _addingTimeScaleCoroutine;
        
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

        public void AddSkin(SkinType skinType)
        {
            _skins ??= new List<SkinType>();
            _skins.Add(skinType);
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
        
        public void SetSkins(List<SkinType> skins, SkinType skinNow)
        {
            _skins = new List<SkinType>(skins);
            _skinNow = skinNow;
            skinHandler.SetSkin(skinNow);
        }

        public void Save()
        {
            SaveData data = new (){Coins = _coins, RecordScore = _recordScore};

            SaveLoadSystem.SaveData(data);
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