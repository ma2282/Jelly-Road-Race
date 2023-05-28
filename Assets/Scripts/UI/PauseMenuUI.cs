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

        public bool IsPaused { get; private set; }

        public void Initialize()
        {
            pauseButton.onClick.AddListener(PauseGame);
            resumeButton.onClick.AddListener(ResumeGame);
            homeButton.onClick.AddListener(StopGame);
            
            IsPaused = false;

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
            Time.timeScale = 0;
            
            IsPaused = true;
            
            gameObject.SetActive(true);
        }

        public void ResumeGame()
        {
            Time.timeScale = _timeScaleBackup;

            IsPaused = false;
            
            gameObject.SetActive(false);
        }

        public void ChangeRecordScore(int recordScore)
        {
            recordScoreText.text = recordScore.ToString();
        }
    }
}
