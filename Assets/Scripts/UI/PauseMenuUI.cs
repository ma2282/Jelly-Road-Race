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

        private void Start()
        {
            pauseButton.onClick.AddListener(PauseGame);
            resumeButton.onClick.AddListener(ResumeGame);
            homeButton.onClick.AddListener(StopGame);
            gameObject.SetActive(false);
        }

        public void Initialize()
        {
            GameManager.Instance.IsPaused = false;

            Time.timeScale = 1f;
            
            gameObject.SetActive(false);
        }

        private void StopGame()
        {
            GameManager.Instance.StopGame();
        }
        
        public void PauseGame()
        {
            _timeScaleBackup = Time.timeScale;
            Time.timeScale = 0f;
            
            GameManager.Instance.IsPaused = true;
            
            gameObject.SetActive(true);
        }

        public void ResumeGame()
        {
            Time.timeScale = _timeScaleBackup;

            GameManager.Instance.IsPaused = false;
            
            gameObject.SetActive(false);
        }

        public void ChangeRecordScore(int recordScore)
        {
            recordScoreText.text = recordScore.ToString();
        }
    }
}
