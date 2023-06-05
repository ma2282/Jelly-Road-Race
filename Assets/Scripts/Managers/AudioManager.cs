using NTC.Global.System;
using UnityEngine;
using UnityEngine.Audio;

namespace Game.Gameplay
{
    public class AudioManager : Singleton<AudioManager>
    {
        [SerializeField] private AudioMixerGroup masterMixer;
        [SerializeField] private SettingsUI settingsUI;
        [SerializeField] private AudioMixerSnapshot mainSnapshot;
        [SerializeField] private AudioMixerSnapshot menuSnapshot;
        
        private float _volume;
        private float _musicVolume;

        private void Start()
        {
            _volume = PlayerPrefs.GetFloat("MasterVolume");
            _musicVolume = PlayerPrefs.GetFloat("MusicVolume");
            settingsUI.InitializeVolume(_volume, _musicVolume);
            ChangeVolume(_volume);
            ChangeMusicVolume(_musicVolume);
            SetMenu();
        }

        public void SetMenu() => menuSnapshot.TransitionTo(0.25f);

        public void SetGameplay() => mainSnapshot.TransitionTo(0.25f);

        public void ChangeVolume(float value)
        {
            _volume = Mathf.Lerp(-80, 0, value);
            masterMixer.audioMixer.SetFloat("MasterVolume", _volume);
            PlayerPrefs.SetFloat("MasterVolume", value);
        }

        public void ChangeMusicVolume(float value)
        {
            _musicVolume = Mathf.Lerp(-80, 0, value);
            masterMixer.audioMixer.SetFloat("MusicVolume", _musicVolume);
            PlayerPrefs.SetFloat("MusicVolume", value);
        }
    }
}