using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class PauseMenuUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI recordScoreText;
        [SerializeField] private Button pauseButton;
        [SerializeField] private Button resumeButton;
        [SerializeField] private Button homeButton;

        private float _timeScaleBackup;

        public void Initialize()
        {
            pauseButton.onClick.AddListener(PauseGame);
            resumeButton.onClick.AddListener(ResumeGame);
            homeButton.onClick.AddListener(StopGame);
        }

        private void StopGame()
        {
            GameManager.Instance.GameState = GameState.Stopped;
        }
        
        public void PauseGame()
        {
            GameManager.Instance.IsPaused = true;
            
            gameObject.SetActive(true);
        }

        public void ResumeGame()
        {
            GameManager.Instance.IsPaused = false;
            
            gameObject.SetActive(false);
        }

        public void ChangeRecordScore(int recordScore)
        {
            recordScoreText.text = recordScore.ToString();
        }
    }
}
