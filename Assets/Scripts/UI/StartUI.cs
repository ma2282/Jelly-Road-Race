using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class StartUI : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Button exitButton;
        [SerializeField] private Button shopButton;

        public void Initialize()
        {
            playButton.onClick.AddListener(StartGame);
            settingsButton.onClick.AddListener(ShowSettings);
            exitButton.onClick.AddListener(ExitGame);
            shopButton.onClick.AddListener(ShowShop);
        }

        private void StartGame()
        {
            GameManager.Instance.GameState = GameState.Started;
        }

        private void ShowSettings()
        {
            UIManager.Instance.ShowSettings();
        }

        private void ShowShop()
        {
            UIManager.Instance.ShowShop();
        }

        private void ExitGame()
        {
            GameManager.Instance.ExitGame();
        }
    }
}