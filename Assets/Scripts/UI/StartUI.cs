using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class StartUI : MonoBehaviour
    {
        [SerializeField] private Button playButton;

        private void Start()
        {
            playButton.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            GameManager.Instance.StartGame();
        }
    }
}