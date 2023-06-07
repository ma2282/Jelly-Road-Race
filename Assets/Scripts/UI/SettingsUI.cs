using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class SettingsUI : UICanvas
    {
        [SerializeField] public Button exitButton;
        [SerializeField] public ToggleSlider volumeToggle;
        [SerializeField] public ToggleSlider musicToggle;

        public override void Initialize()
        {
            exitButton.onClick.AddListener(Close);
            volumeToggle.onClick.AddListener(AudioManager.Instance.ChangeVolume);
            musicToggle.onClick.AddListener(AudioManager.Instance.ChangeMusicVolume);
        }

        public void InitializeVolume(float volume, float musicVolume)
        {
            volumeToggle.InitializeValue(volume);
            musicToggle.InitializeValue(musicVolume);
        }
    }
}

