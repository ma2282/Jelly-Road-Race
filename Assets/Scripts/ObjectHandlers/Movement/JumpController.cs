using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class JumpController : MonoBehaviour
    {
        [SerializeField] protected MovementController movementController;
        
        protected bool _isEnabled;
        protected float _jumpTime = 1f;
        protected float _startHeight = 1f;
        protected float _timeNow;
        protected AnimationCurve _jumpCurve;

        protected Transform _transform;
        
        protected CoroutineObject _jumpCoroutine;

        public UnityEvent OnJumpingStart;
        public UnityEvent OnJumpingEnd;

        private void Start()
        {
            _transform = transform;
            _jumpCoroutine = new CoroutineObject(this, JumpCoroutine);
        }

        public void Initialize(float jumpTime, AnimationCurve jumpCurve)
        {
            _jumpTime = jumpTime;
            _jumpCurve = jumpCurve;
        }

        public void Jump()
        {
            if (!_isEnabled || _jumpCoroutine.IsProcessing) return;
            
            movementController.Deactivate();
            _startHeight = _transform.position.y;
            
            _jumpCoroutine.Start();
            OnJumpingStart?.Invoke();
        }

        protected IEnumerator JumpCoroutine()
        {
            while (_timeNow < 1f)
            {
                _timeNow += 1 / _jumpTime * Time.deltaTime;
                ChangePosition();
                yield return null;
            }

            Vector3 endPosition = _transform.position;
            endPosition.y = _startHeight;

            _timeNow = 0f;
            movementController.Activate();

            _transform.position = endPosition;
            
            OnJumpingEnd?.Invoke();
        }

        private void ChangePosition()
        {
            Vector3 position = _transform.position;
            position.y = _startHeight + _jumpCurve.Evaluate(_timeNow);
                
            _transform.position = position;
        }

        public void Activate() => _isEnabled = true;

        public void Deactivate() => _isEnabled = false;
    }
}