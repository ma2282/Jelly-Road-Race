using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private Button restartButton;

        private void Start()
        {
            restartButton.onClick.AddListener(RestartGame);
        }

        private void RestartGame()
        {
            GameManager.Instance.StartGame();
        }
    }
}