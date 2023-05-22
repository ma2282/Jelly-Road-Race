using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int positionState = 1;
        [SerializeField] private float health = 1f;
        [SerializeField] private float moveSpeed = 1f;
        [SerializeField] private float epsilonSqrMagnitude;
        [SerializeField] private Vector3[] allPositions;
        [SerializeField] private Transform trailTransform;

        private static readonly int DamageTrigger = Animator.StringToHash("TakeDamage");
        private static readonly int HealTrigger = Animator.StringToHash("Heal");
        private static readonly int IdleBool = Animator.StringToHash("IsIdle");


        private float moveDistance;
        
        private Quaternion _targetRotation;
        private Vector3 _targetPosition;

        private Transform _transform;
        private BoxCollider _collider;
        private JellyMesh _jellyMesh;
        
        private Animator _animator;
            
        private CoroutineObject _moveCoroutine;

        public UnityEvent OnKilled;
        

        public float Health
        {
            get => health;
            private set
            {
                if (value < 0f || health < 0f)
                    Kill();
                else
                {
                    health = value;
                    UpdateMass();
                }
            }
        }

        private void Start()
        {
            _transform = GetComponent<Transform>();
            _animator = GetComponent<Animator>();
            _collider = GetComponent<BoxCollider>();
            _jellyMesh = GetComponentInChildren<JellyMesh>();
            
            _moveCoroutine = new CoroutineObject(this, MoveCoroutine);
        }

        public void Move(float horizontalMovement)
        {
            if (_moveCoroutine.IsProcessing) return;

            if (positionState == 0 && horizontalMovement < 0) return;
            if (positionState == (allPositions.Length - 1) && horizontalMovement > 0) return;
            
            ChunkManager.Instance.SpawnTrail(trailTransform.gameObject);
            trailTransform.gameObject.SetActive(false);
            
            moveDistance = allPositions[positionState].x;
            
            if (horizontalMovement > 0)
                positionState++;
            else
                positionState--;
            
            Vector3 movement = new (horizontalMovement, 0, 0);

            moveDistance = Mathf.Abs(moveDistance - allPositions[positionState].x);

            _targetPosition = allPositions[positionState];
            _targetRotation = Quaternion.FromToRotation(movement, Vector3.down) * _transform.rotation;

            _moveCoroutine.Start();
        }

        private IEnumerator MoveCoroutine()
        {
            _animator.SetBool(IdleBool, false);
            while ((_transform.position - _targetPosition).magnitude > epsilonSqrMagnitude)
            {
                _transform.position = Vector3.MoveTowards(_transform.position, _targetPosition, moveSpeed * Time.deltaTime);

                _transform.localRotation = Quaternion.RotateTowards(_transform.localRotation, _targetRotation, 90f * (1 / moveDistance) * moveSpeed * Time.deltaTime);

                yield return null;
            }
            _transform.position = _targetPosition;
            _transform.rotation = _targetRotation;
            
            _animator.SetBool(IdleBool, true);
            
            trailTransform.rotation = Quaternion.identity;
            trailTransform.gameObject.SetActive(true);
            yield break;
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0f)
                throw new ArgumentException("Damage less than zero");

            _animator.SetTrigger(DamageTrigger);
            
            Health -= damage;
        }

        public void Heal(float healthPoint)
        {
            if (healthPoint < 0f)
                throw new ArgumentException("Health Point less than zero");

            _animator.SetTrigger(HealTrigger);
            
            ColorsManager.Instance.ChangeColor();
            
            Health += healthPoint;
        }
        
        private void Kill()
        {
            OnKilled.Invoke();
        }

        private void UpdateMass()
        {
            _jellyMesh.Mass = health + health / 2;
        }
    }
}