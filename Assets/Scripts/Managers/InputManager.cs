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
            _horizontalMovement = Input.GetAxis("Horizontal");

            if (_horizontalMovement != 0f || _verticalMovement != 0f)
                GameManager.Instance.Player.Move(_horizontalMovement);
        }
    }
}