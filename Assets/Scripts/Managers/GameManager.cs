using System;
using System.Collections;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private float maxTimeScale;
        [SerializeField] private float minTimeScale;
        [SerializeField] private float timeScaleStep;

        [SerializeField] private Player player;

        [SerializeField] private GameObject[] gameplayGameObjects;
        [SerializeField] private GameObject[] homeGameObjects;

        private CoroutineObject _addingScoreCoroutine;

        public Player Player => player;

        private void Start()
        {
            _addingScoreCoroutine = new CoroutineObject(this, AddingScore);
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
            UIManager.Instance.StartGame();
        }
        
        private void InitializeHome()
        {
            player.Reset();
            ChunkManager.Instance.Reset();
            _addingScoreCoroutine.Stop();
            ValuesManager.Instance.Save();
        }
        
        public void StopGame()
        {
            foreach (GameObject obj in gameplayGameObjects)
                obj.SetActive(false);
            
            foreach (GameObject obj in homeGameObjects)
                obj.SetActive(true);

            InitializeHome();
        }
        
        public void StartGame()
        {
            foreach (GameObject obj in homeGameObjects)
                obj.SetActive(false);
            
            foreach (GameObject obj in gameplayGameObjects)
                obj.SetActive(true);

            InitializeGameplay();
        }
    }
}