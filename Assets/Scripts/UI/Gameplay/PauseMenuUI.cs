using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class PauseMenuUI : MonoBehaviour
    {
        [SerializeField] private Button pauseButton;
        [SerializeField] private Button resumeButton;

        private float _timeScaleBackup;

        public bool IsPaused { get; private set; }


        private void Start()
        {
            pauseButton.onClick.AddListener(PauseGame);
            resumeButton.onClick.AddListener(ResumeGame);
            
            gameObject.SetActive(false);
        }

        public void PauseGame()
        {
            gameObject.SetActive(true);
            
            _timeScaleBackup = Time.timeScale;
            Time.timeScale = 0;
            
            IsPaused = true;
        }

        public void ResumeGame()
        {
            gameObject.SetActive(false);
            
            Time.timeScale = _timeScaleBackup;

            IsPaused = false;
        }
    }
}
