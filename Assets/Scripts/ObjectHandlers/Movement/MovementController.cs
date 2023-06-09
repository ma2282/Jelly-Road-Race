using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class MovementController : MonoBehaviour, IMovementController
    {
        [SerializeField] protected float defaultMoveSpeed;
        [SerializeField] protected float moveSpeed;
        [SerializeField] protected int startPositionIndex;
        [SerializeField] protected Vector3[] allPositions;

        protected bool _isEnabled = true;
        protected bool _isMoving;
        
        protected int _positionIndex;

        protected Transform _ownerTransform;

        protected SkinObject _skinObject;

        public bool CanJump { get; set; }
        
        public float SpeedRate { get; set; } = 1f;

        public float MoveSpeed => moveSpeed;

        public UnityEvent OnMovingStart;
        public UnityEvent OnMovingEnd;

        private void Start()
        {
            Initialize();
            ResetPosition();
        }

        private void Initialize()
        {
            _ownerTransform = transform;
        }

        public void SetSkinObject(ReadonlySkin skin)
        {
            skin.SkinObject.OnMovingEnd.AddListener(EndMove);
            _skinObject = skin.SkinObject;
            _skinObject.Speed = moveSpeed;
        }

        public void Move(float horizontalMovement)
        {
            if (!_isEnabled || _isMoving) return;

            if (_positionIndex == 0 && horizontalMovement < 0 ||
                _positionIndex == allPositions.Length - 1 && horizontalMovement > 0)
                return;
            
            _positionIndex = horizontalMovement > 0 ? _positionIndex + 1 : _positionIndex - 1;
            
            if (horizontalMovement < 0)
                _skinObject.MoveLeft();
            else
                _skinObject.MoveRight();

            _isMoving = true;
            
            OnMovingStart?.Invoke();
        }
        
        private void EndMove()
        {
            _isMoving = false;

            _ownerTransform.position = allPositions[_positionIndex];

            OnMovingEnd?.Invoke();
        }

        public void ResetPosition()
        {
            if (_ownerTransform == null)
                Initialize();
            
            _positionIndex = startPositionIndex;

            _ownerTransform.position = Vector3.zero;
            
            _skinObject.Reset();
        }

        public void ResetParams()
        {
            moveSpeed = defaultMoveSpeed;
            SpeedRate = 1f;
        }

        public void Deactivate() => _isEnabled = false;
        
        public void Activate() => _isEnabled = true;
    }
}