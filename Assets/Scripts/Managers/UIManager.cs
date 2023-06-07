using System;
using System.Collections.Generic;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private StartUI startUi;
        [SerializeField] private GameplayUI gameplayUi;
        [SerializeField] private PauseMenuUI pauseMenuUi;
        [SerializeField] private GameOverUI gameOverUi;
        [SerializeField] private SettingsUI settingsUi;
        [SerializeField] private ShopUI shopUi;
            
        private List<IUICanvas> _UIs;
        
        private void Start()
        {
            if (_UIs == null)
                Initialize();
        }

        private void Initialize()
        {
            _UIs = new List<IUICanvas>
            {
                startUi,
                gameplayUi,
                pauseMenuUi,
                gameOverUi,
                settingsUi,
                shopUi
            };

            foreach (IUICanvas uiCanvas in _UIs)
                uiCanvas.Initialize();
        }

        public void ShowUI(GameState gameState)
        {
            if (_UIs == null)
                Initialize();
            
            IUICanvas uiToShow = gameState switch
            {
                GameState.Started => gameplayUi,
                GameState.Stopped => startUi,
                GameState.Finished => gameOverUi,
                _ => throw new ArgumentOutOfRangeException(nameof(gameState), gameState, null)
            };

            foreach (IUICanvas UI in _UIs)
            {
                if (UI == uiToShow)
                    UI.Open();
                else
                    UI.Close();
            }
        }

        public void ShowSettings()
        {
            settingsUi.Open();
        }
        
        public void ShowShop()
        {
            shopUi.Open();
        }

        public void ChangeCoins(int coins)
        {
            shopUi.ChangeCoins(coins);
            gameplayUi.ChangeCoins(coins);
        } 

        public void ChangeScore(int score) => gameplayUi.ChangeScore(score);

        public void ChangeRecordScore(int recordScore) => pauseMenuUi.ChangeRecordScore(recordScore);
    }
}