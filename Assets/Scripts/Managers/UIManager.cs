using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private StartUI startUI;
        [SerializeField] private GameplayUI gameplayUI;
        [SerializeField] private PauseMenuUI pauseMenuUI;
        [SerializeField] private GameOverUI gameOverUI;


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