using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private Button restartButton;

        public void Initialize()
        {
            restartButton.onClick.AddListener(RestartGame);
        }

        private void RestartGame()
        {
            GameManager.Instance.GameState = GameState.Started;
        }
    }
}