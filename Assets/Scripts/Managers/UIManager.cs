using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private GameplayUI gameplayUI;
        [SerializeField] private PauseMenuUI pauseMenuUI;

        public bool IsPaused => pauseMenuUI.IsPaused;

        
        public void PauseGame() => pauseMenuUI.PauseGame();

        public void ResumeGame() => pauseMenuUI.ResumeGame();

        public void ChangeCoins(int coins) => gameplayUI.ChangeCoins(coins);

        public void ChangeScore(int score) => gameplayUI.ChangeScore(score);

        public void ChangeRecordScore(int recordScore) => pauseMenuUI.ChangeRecordScore(recordScore);

        public void StartGame()
        {
            pauseMenuUI.Initialize();
        }
    }
}