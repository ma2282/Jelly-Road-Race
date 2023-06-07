using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class PauseMenuUI : UICanvas
    {
        [SerializeField] private TextMeshProUGUI recordScoreText;
        [SerializeField] private Button pauseButton;
        [SerializeField] private Button resumeButton;
        [SerializeField] private Button homeButton;

        public override void Initialize()
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
            TimeManager.Instance.PauseGame();
            
            Open();
        }

        public void ResumeGame()
        {
            TimeManager.Instance.ResumeGame();
            
            Close();
        }

        public void ChangeRecordScore(int recordScore)
        {
            recordScoreText.text = recordScore.ToString();
        }
    }
}
