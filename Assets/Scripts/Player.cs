using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    [RequireComponent(typeof(JellyMesh))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 1f;
        [SerializeField] private float moveDistance = 2f;
        [SerializeField] private int maxPositionState = 2;
        [SerializeField] private int minPositionState = -2;
        
        private int positionState;

        private Quaternion _targetRotation;
        private Vector3 _targetPosition;

        private Transform _transform;
        private CoroutineObject _moveCoroutine;

        private void Start()
        {
            _transform = GetComponent<Transform>();
            _moveCoroutine = new CoroutineObject(this, MoveCoroutine);
        }

        public void Move(float horizontalMovement)
        {
            if (_moveCoroutine.IsProcessing) return;

            if (positionState == minPositionState && horizontalMovement < 0) return;
            if (positionState == maxPositionState && horizontalMovement > 0) return;
                
            Vector3 movement = new Vector3(horizontalMovement, 0, 0).normalized * moveDistance;

            _targetPosition = _transform.position + movement;
            _targetRotation = Quaternion.FromToRotation(movement, Vector3.down) * _transform.rotation;

            if (horizontalMovement > 0)
                positionState++;
            else
                positionState--;

            _moveCoroutine.Start();
        }

        private IEnumerator MoveCoroutine()
        {
            while ((_transform.position - _targetPosition).sqrMagnitude > moveSpeed * Time.deltaTime)
            {
                _transform.position = Vector3.MoveTowards(_transform.position, _targetPosition, moveSpeed * Time.deltaTime);

                _transform.rotation = Quaternion.RotateTowards(_transform.rotation, _targetRotation, 90f * (1 / moveDistance) * moveSpeed * Time.deltaTime);

                yield return null;
            }
            _transform.position = _targetPosition;
            _transform.rotation = _targetRotation;
            yield break;
        }
    }
}