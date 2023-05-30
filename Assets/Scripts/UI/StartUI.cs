using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class StartUI : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Button exitButton;

        public void Initialize()
        {
            playButton.onClick.AddListener(StartGame);
            settingsButton.onClick.AddListener(ShowSettings);
            exitButton.onClick.AddListener(ExitGame);
        }

        private void StartGame()
        {
            GameManager.Instance.GameState = GameState.Started;
        }

        private void ShowSettings()
        {
            UIManager.Instance.ShowSettings();
        }

        private void ExitGame()
        {
            GameManager.Instance.ExitGame();
        }
    }
}