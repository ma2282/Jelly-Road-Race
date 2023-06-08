using System;
using System.Collections;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class TimeManager : Singleton<TimeManager>
    {
        [SerializeField] private float timeRate = 0.5f;
        [SerializeField] private float maxTimeScale = 2f;

        private float _timeScaleNow;

        private CoroutineObject _addingTimeSpeedCoroutine;

        public bool IsPaused { get; private set; }

        public float TimeScale
        {
            get => Time.timeScale;
            set => Time.timeScale = Mathf.Min(maxTimeScale, value);
        }

        private void Start()
        {
            Application.targetFrameRate = 60;
            Initialize();
        }

        private void Initialize()
        {
            _addingTimeSpeedCoroutine = new CoroutineObject(this, AddingTimeSpeedCoroutine);
        }

        private IEnumerator AddingTimeSpeedCoroutine()
        {
            while (true)
            {
                if (!IsPaused)
                    TimeScale += timeRate / TimeScale;
                yield return new WaitForSeconds(1f);
            }
        }

        public void PauseGame()
        {
            IsPaused = true;

            _timeScaleNow = TimeScale;
            TimeScale = 0f;
        }

        public void ResumeGame()
        {
            IsPaused = false;

            TimeScale = _timeScaleNow;
        }

        public void StartGame()
        {
            if (_addingTimeSpeedCoroutine == null)
                Initialize();

            _addingTimeSpeedCoroutine.Start();

            TimeScale = _timeScaleNow = 1f;

            ResumeGame();
        }

        public void StopGame()
        {
            if (_addingTimeSpeedCoroutine == null)
                Initialize();

            _addingTimeSpeedCoroutine.Stop();

            TimeScale = _timeScaleNow = 1f;

            PauseGame();
        }
    }
}