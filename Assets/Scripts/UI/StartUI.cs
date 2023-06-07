using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class StartUI : UICanvas
    {
        [SerializeField] private float changeColorsRate;
        [SerializeField] private Button playButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Button exitButton;
        [SerializeField] private Button shopButton;

        public override void Initialize()
        {
            playButton.onClick.AddListener(StartGame);
            settingsButton.onClick.AddListener(UIManager.Instance.ShowSettings);
            exitButton.onClick.AddListener(GameManager.Instance.ExitGame);
            shopButton.onClick.AddListener(UIManager.Instance.ShowShop);
        }

        private void Update()
        {
            if (GameManager.Instance.GameState != GameState.Stopped) return;
            
            float colorHue = Mathf.Repeat(Time.unscaledTime, changeColorsRate) / changeColorsRate;
            Color color = Color.HSVToRGB(colorHue, 1f, 1f);
            ColorsManager.Instance.ChangeColor(color);
        }

        private void StartGame()
        {
            GameManager.Instance.GameState = GameState.Started;
        }
    }
}