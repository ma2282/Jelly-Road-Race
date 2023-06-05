using System;
using System.Collections.Generic;
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
        [SerializeField] private SettingsUI settingsUI;
        [SerializeField] private ShopUI shopUI;
            
        private List<GameObject> _UIs;
        
        private void Start()
        {
            startUI.Initialize();
            gameplayUI.Initialize();
            pauseMenuUI.Initialize();
            gameOverUI.Initialize();
            settingsUI.Initialize();
            shopUI.Initialize();

            _UIs = new List<GameObject>
            {
                startUI.gameObject,
                gameplayUI.gameObject,
                pauseMenuUI.gameObject,
                gameOverUI.gameObject,
                settingsUI.gameObject,
                shopUI.gameObject
            };
        }

        public void ShowUI(GameState gameState)
        {
            GameObject UIToShow = gameState switch
            {
                GameState.Started => gameplayUI.gameObject,
                GameState.Stopped => startUI.gameObject,
                GameState.Finished => gameOverUI.gameObject,
                _ => throw new ArgumentOutOfRangeException(nameof(gameState), gameState, null)
            };

            foreach (GameObject UI in _UIs)
                UI.gameObject.SetActive(UI == UIToShow);
        }

        public void ShowSettings()
        {
            settingsUI.gameObject.SetActive(true);
        }
        
        public void ShowShop()
        {
            shopUI.gameObject.SetActive(true);
        }

        public void ChangeCoins(int coins)
        {
            shopUI.ChangeCoins(coins);
            gameplayUI.ChangeCoins(coins);
        } 

        public void ChangeScore(int score) => gameplayUI.ChangeScore(score);

        public void ChangeRecordScore(int recordScore) => pauseMenuUI.ChangeRecordScore(recordScore);
    }
}