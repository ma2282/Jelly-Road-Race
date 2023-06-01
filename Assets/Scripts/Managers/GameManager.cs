using System;
using System.Collections;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private float maxTimeScale;
        [SerializeField] private float minTimeScale;
        [SerializeField] private float timeScaleStep;

        [SerializeField] private Player mainPlayer;

        private bool _isPaused = true;
        private float _timeBackup;
        
        
        public bool IsPaused
        {
            get => _isPaused;
            set
            {
                _isPaused = value;
                if (_isPaused)
                {
                    _timeBackup = Time.timeScale != 0f ? Time.timeScale : _timeBackup;
                    Time.timeScale = 0f;
                }
                else
                    Time.timeScale = _timeBackup != 0f ? _timeBackup : Time.timeScale;
            }
        }

        public GameState GameState
        {
            set
            {
                UIManager.Instance.ShowUI(value);

                switch (value)
                {
                    case GameState.Started:
                        InitializeGameplay();
                        break;
                    case GameState.Finished:
                    case GameState.Stopped:
                        InitializeHome();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
            }
        }

        public void GameOver()
        {
            GameState = GameState.Finished;
        }

        public void ChangeTimeScale(float verticalMovement)
        {
            Time.timeScale = verticalMovement < 0f
                ? Mathf.Max(Time.timeScale - timeScaleStep, minTimeScale)
                : Mathf.Min(Time.timeScale + timeScaleStep, maxTimeScale);
        }

        private void OnApplicationQuit()
        {
            ValuesManager.Instance.Save();
            ColorsManager.Instance.ResetColors();
        }

        private void InitializeGameplay()
        {
            ChunkManager.Instance.StartMoving();
            ValuesManager.Instance.StartScore();
            IsPaused = false;
        }

        private void InitializeHome()
        {
            mainPlayer.Reset();
            ChunkManager.Instance.Reset();
            ValuesManager.Instance.StopScore();
            ValuesManager.Instance.Save();
            ValuesManager.Instance.ResetScore();
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}