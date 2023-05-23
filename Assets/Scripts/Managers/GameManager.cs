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

        public Player Player => player;

        public void ChangeTimeScale(float verticalMovement)
        {
            Time.timeScale = verticalMovement < 0f
                ? Mathf.Max(Time.timeScale - timeScaleStep, minTimeScale)
                : Mathf.Min(Time.timeScale + timeScaleStep, maxTimeScale);
        }
    }
}