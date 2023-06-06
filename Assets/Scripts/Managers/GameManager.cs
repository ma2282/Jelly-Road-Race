using System;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private Player mainPlayer;
        
        private GameState _gameState;

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

        private void OnApplicationFocus(bool hasFocus)
        {
            if (hasFocus) return;
            
            ColorsManager.Instance.ResetColors();
            
            SaveGameData();
        }

        private void SaveGameData()
        {
            SaveData data = ValuesManager.Instance.Save();
            data.SetSkinsInfo(SkinsManager.Instance.Save());

            SaveLoadSystem.SaveData(data);
        }

        private void InitializeGameplay()
        {
            ChunkManager.Instance.StartMoving();
            ValuesManager.Instance.StartScore();
            AudioManager.Instance.SetGameplay();
            TimeManager.Instance.StartGame();
        }

        private void InitializeHome()
        {
            mainPlayer.Reset();
            ChunkManager.Instance.Reset();
            ValuesManager.Instance.StopScore();
            ValuesManager.Instance.Save();
            ValuesManager.Instance.RestoreDefaults();
            AudioManager.Instance.SetMenu();
            TimeManager.Instance.StopGame();
        }

        public void ExitGame()
        {
            ColorsManager.Instance.ResetColors();
            
            SaveGameData();
            
            Application.Quit();
        }
    }
}