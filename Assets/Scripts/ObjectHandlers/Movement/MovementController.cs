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

        protected const float DISTANCE_EPSILON = 0.1f;

        protected int _previousPositionIndex;
        protected int _positionIndex;

        protected Vector3 _targetPosition;
        protected Quaternion _targetRotation;
        
        protected Transform _ownerTransform;
        protected CoroutineObject _moveCoroutine;

        public float SpeedRate { get; set; } = 1f;

        public float MoveSpeed => moveSpeed;
        
        public UnityEvent OnMovingStart;
        public UnityEvent OnMovingEnd;

        private void Start()
        {
            _ownerTransform = transform;
            _moveCoroutine = new CoroutineObject(this, MoveCoroutine);

            ResetPosition();
        }

        public void Move(float horizontalMovement)
        {
            if (_moveCoroutine.IsProcessing) return;

            if (_positionIndex == 0 && horizontalMovement < 0 ||
                _positionIndex == allPositions.Length - 1 && horizontalMovement > 0)
                return;

            _previousPositionIndex = _positionIndex;
            _positionIndex = horizontalMovement > 0 ? _positionIndex + 1 : _positionIndex - 1;

            Vector3 movement = Vector3.right * horizontalMovement;
            
            _targetPosition = allPositions[_positionIndex];
            _targetRotation = Quaternion.FromToRotation(movement, Vector3.down) * _ownerTransform.rotation;

            _moveCoroutine.Start();
            
            OnMovingStart?.Invoke();
        }
        
        private IEnumerator MoveCoroutine()
        {
            while ((_ownerTransform.position - _targetPosition).magnitude > DISTANCE_EPSILON)
            {
                ChangePosition();
                
                yield return null;
            }
            _ownerTransform.position = _targetPosition;
            _ownerTransform.rotation = _targetRotation;
            
            OnMovingEnd?.Invoke();
        }

        private void ChangePosition()
        {
            float maxDistanceDelta = SpeedRate * moveSpeed * Time.deltaTime;
                
            _ownerTransform.position =
                Vector3.MoveTowards(_ownerTransform.position, _targetPosition, maxDistanceDelta);

            float moveDistanceNow = Mathf.Abs(allPositions[_previousPositionIndex].x - allPositions[_positionIndex].x);
            float maxDegreesDelta = 90f / moveDistanceNow * maxDistanceDelta;
                
            _ownerTransform.localRotation = 
                Quaternion.RotateTowards(_ownerTransform.localRotation, _targetRotation, maxDegreesDelta);
        }

        public void ResetPosition()
        {
            _positionIndex = startPositionIndex;

            _ownerTransform.position = allPositions[_positionIndex];
        }

        public void ResetParams()
        {
            moveSpeed = defaultMoveSpeed;
            SpeedRate = 1f;
        }
    }
}