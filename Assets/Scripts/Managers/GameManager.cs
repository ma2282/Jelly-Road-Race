using System;
using System.Collections;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private Player mainPlayer;

        private bool _isPaused = true;
        private float _timeBackup;
        private GameState _gameState;
        
        
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
            get => _gameState;
            set
            {
                _gameState = value;
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

        private void OnApplicationQuit()
        {
            SaveData data = ValuesManager.Instance.Save();
            data.SetSkinsInfo(SkinsManager.Instance.Save());
            
            ColorsManager.Instance.ResetColors();
            
            SaveLoadSystem.SaveData(data);
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
            ValuesManager.Instance.RestoreDefaults();
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}