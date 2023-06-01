using System;
using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class InputManager : Singleton<InputManager>
    {
        [SerializeField] private MovementController mainMovementController;
        [SerializeField] private JumpController mainJumpController;
        [SerializeField] private ColorsInventory mainColorsInventory;
        
        private float _horizontalMovement;
        private float _verticalMovement;
        
        private void Update()
        {
            if (!GameManager.Instance.IsPaused)
            {
                _horizontalMovement = (Input.GetKeyDown(KeyCode.D) ? 1f : 0f) + (Input.GetKeyDown(KeyCode.A) ? -1f : 0f);
                _verticalMovement = (Input.GetKeyDown(KeyCode.W) ? 1f : 0f) + (Input.GetKeyDown(KeyCode.S) ? -1f : 0f);
            
                if (_horizontalMovement != 0f)
                    mainMovementController.Move(_horizontalMovement);

                if (_verticalMovement != 0f)
                    GameManager.Instance.ChangeTimeScale(_verticalMovement);

                if (Input.GetKeyDown(KeyCode.Q))
                    mainColorsInventory.ShiftColor(-1);
                
                if (Input.GetKeyDown(KeyCode.E))
                    mainColorsInventory.ShiftColor(1);

                if (Input.GetKeyDown(KeyCode.Space) && mainJumpController.gameObject.activeInHierarchy)
                    mainJumpController.Jump();
            }
        }
    }
}