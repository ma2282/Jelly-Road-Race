using System;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class InputManager : Singleton<InputManager>
    {
        private float _horizontalMovement;
        private float _verticalMovement;
        
        private void Update()
        {
            print(UIManager.Instance.IsPaused);
            if (!UIManager.Instance.IsPaused)
            {
                _horizontalMovement = (Input.GetKeyDown(KeyCode.D) ? 1f : 0f) + (Input.GetKeyDown(KeyCode.A) ? -1f : 0f);
                _verticalMovement = (Input.GetKeyDown(KeyCode.W) ? 1f : 0f) + (Input.GetKeyDown(KeyCode.S) ? -1f : 0f);
            
                if (_horizontalMovement != 0f)
                    GameManager.Instance.Player.Move(_horizontalMovement);

                if (_verticalMovement != 0f)
                    GameManager.Instance.ChangeTimeScale(_verticalMovement);
            }
        }
    }
}