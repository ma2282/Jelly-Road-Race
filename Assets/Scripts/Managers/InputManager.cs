using System;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class InputManager : Singleton<InputManager>
    {
        [SerializeField] private float minDistanceForSwipe = 20f;
        [SerializeField] private MovementController mainMovementController;
        [SerializeField] private JumpController mainJumpController;
        [SerializeField] private ColorsInventory mainColorsInventory;

        private float _horizontalMovement;
        private float _verticalMovement;

        private Vector2 _fingerUpPosition;
        private Vector2 _fingerDownPosition;
        
        private Touch _touch;

        public UnityEvent OnTouchClick;
        public UnityEvent OnSwipeLeft;
        public UnityEvent OnSwipeRight;
        public UnityEvent OnSwipeUp;
        public UnityEvent OnSwipeDown;

        private void Start()
        {
            OnTouchClick.AddListener(() => mainJumpController.Jump());
            OnSwipeLeft.AddListener(() => mainMovementController.Move(-1f));
            OnSwipeRight.AddListener(() => mainMovementController.Move(1f));
            OnSwipeUp.AddListener(() => mainColorsInventory.ShiftColor(1));
            OnSwipeDown.AddListener(() => mainColorsInventory.ShiftColor(-1));
        }
        
        private void Update()
        {
            switch (Application.platform)
            {
                #if UNITY_EDITOR
                case RuntimePlatform.WindowsEditor:
                {
                    ProcessUnityInput();
                    break;
                }
                #endif
                case RuntimePlatform.Android:
                {
                    ProcessAndroidInput();
                    break;
                }
                default:
                    break;
            }
        }

        private void ProcessAndroidInput()
        {
            if (TimeManager.Instance.IsPaused || GameManager.Instance.GameState == GameState.Finished) return;
            
            if (Input.touchCount == 1)
            {
                _touch = Input.GetTouch(0);
                    
                switch (_touch.phase)
                {
                    case TouchPhase.Began:
                        _fingerUpPosition = _touch.position;
                        _fingerDownPosition = _touch.position;
                        break;
                    case TouchPhase.Ended:
                    {
                        _fingerUpPosition = _touch.position;
                        if (!TryDetectSwipe() && mainJumpController.gameObject.activeInHierarchy)
                            OnTouchClick?.Invoke();
                        break;
                    }
                    default:
                        break;
                }
            }
        }
        
        private bool TryDetectSwipe()
        {
            if (Vector2.Distance(_fingerDownPosition, _fingerUpPosition) < minDistanceForSwipe)
                return false;

            if (Mathf.Abs(_fingerDownPosition.y - _fingerUpPosition.y) >
                Mathf.Abs(_fingerDownPosition.x - _fingerUpPosition.x))
            {
                if (_fingerUpPosition.y - _fingerDownPosition.y > 0)
                    OnSwipeUp?.Invoke();
                else
                    OnSwipeDown?.Invoke();
            }
            else
            {
                if (_fingerUpPosition.x - _fingerDownPosition.x > 0)
                    OnSwipeRight?.Invoke();
                else
                    OnSwipeLeft?.Invoke();
            }

            return true;
        }

        #if UNITY_EDITOR
        private void ProcessUnityInput()
        {
            if (TimeManager.Instance.IsPaused || GameManager.Instance.GameState == GameState.Finished) return;
            
            _horizontalMovement = (Input.GetKeyDown(KeyCode.D) ? 1f : 0f) + (Input.GetKeyDown(KeyCode.A) ? -1f : 0f);
            _verticalMovement = (Input.GetKeyDown(KeyCode.W) ? 1f : 0f) + (Input.GetKeyDown(KeyCode.S) ? -1f : 0f);
            
            if (_horizontalMovement != 0f)
                mainMovementController.Move(_horizontalMovement);

            if (_verticalMovement != 0f)
                mainColorsInventory.ShiftColor((int)_verticalMovement);

            if (Input.GetKeyDown(KeyCode.Space) && mainJumpController.gameObject.activeInHierarchy)
                mainJumpController.Jump();
        }
        #endif
    }
}