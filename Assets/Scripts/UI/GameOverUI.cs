using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class GameOverUI : UICanvas
    {
        [SerializeField] private Button restartButton;

        public override void Initialize()
        {
            restartButton.onClick.AddListener(RestartGame);
        }

        private void RestartGame()
        {
            Close();
            GameManager.Instance.GameState = GameState.Started;
        }
    }
}