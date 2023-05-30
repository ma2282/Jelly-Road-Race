using System;
using System.Collections;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private float maxTimeScale;
        [SerializeField] private float minTimeScale;
        [SerializeField] private float timeScaleStep;

        [SerializeField] private Player player;

        private bool _isPaused = true;
        private float _timeBackup;
        
        private CoroutineObject _addingScoreCoroutine;

        public bool IsPaused
        {
            get => _isPaused;
            set
            {
                _isPaused = value;
                if (_isPaused)
                {
                    _timeBackup = Time.timeScale != 0f ? Time.timeScale : _timeBackup;
                    Time.timeScale = 0f;
                }
                else
                    Time.timeScale = _timeBackup != 0f ? _timeBackup : Time.timeScale;
            }
        }

        public GameState GameState
        {
            set => ChangeGameState(value);
        }

        public Player Player => player;

        private void Start()
        {
            _addingScoreCoroutine = new CoroutineObject(this, AddingScore);
            
            player.OnKilled.AddListener(() => GameState = GameState.Finished);
        }

        private IEnumerator AddingScore()
        {
            while (true)
            {
                ValuesManager.Instance.AddScore(1);
                yield return new WaitForSeconds(1f);
            }
        }

        public void ChangeTimeScale(float verticalMovement)
        {
            Time.timeScale = verticalMovement < 0f
                ? Mathf.Max(Time.timeScale - timeScaleStep, minTimeScale)
                : Mathf.Min(Time.timeScale + timeScaleStep, maxTimeScale);
        }

        private void OnApplicationQuit()
        {
            ValuesManager.Instance.Save();
            ColorsManager.Instance.ResetColors();
        }

        private void InitializeGameplay()
        {
            ChunkManager.Instance.StartMoving();
            _addingScoreCoroutine.Start();
            IsPaused = false;
        }

        private void InitializeHome()
        {
            player.Reset();
            ChunkManager.Instance.Reset();
            _addingScoreCoroutine.Stop();
            ValuesManager.Instance.Save();
            ValuesManager.Instance.ResetScore();
        }

        private void SetActiveGameObjects(GameObject[] gameObjects, bool value)
        {
            foreach (GameObject obj in gameObjects)
                obj.SetActive(value);
        }

        private void ChangeGameState(GameState gameState)
        {
            UIManager.Instance.ShowUI(gameState);

            switch (gameState)
            {
                case GameState.Started:
                    InitializeGameplay();
                    break;
                case GameState.Finished:
                case GameState.Stopped:
                    InitializeHome();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameState), gameState, null);
            }
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}