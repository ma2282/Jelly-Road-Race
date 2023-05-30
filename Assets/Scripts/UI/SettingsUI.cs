using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class SettingsUI : MonoBehaviour
    {
        [SerializeField] public Button exitButton;
        [SerializeField] public ToggleSlider volumeToggle;
        [SerializeField] public ToggleSlider musicToggle;

        public void Initialize()
        {
            exitButton.onClick.AddListener(ExitSettings);
            volumeToggle.onClick.AddListener(ChangeVolume);
            musicToggle.onClick.AddListener(ChangeMusic);
        }

        private void ExitSettings()
        {
            gameObject.SetActive(false);
        }

        private void ChangeVolume(float value)
        {
            AudioManager.Instance.ChangeVolume(value);
        }

        private void ChangeMusic(float value)
        {
            AudioManager.Instance.ChangeMusic(value);
        }
    }
}

