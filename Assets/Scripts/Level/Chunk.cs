using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class Chunk : MonoBehaviour
    {
        [SerializeField] private bool canHasPartSample;
        [SerializeField] private float moveSpeed;
        
        [SerializeField] private Vector3 nextSpawnPosition;
        [SerializeField] private Vector3 destroyPosition;
        [SerializeField] private Vector3 partChunkSampleFirstPosition;
        [SerializeField] private Vector3 partChunkSampleSecondPosition;

        private bool _isMoving;

        private Transform _transform;

        public bool CanHasPartSample
        {
            get => canHasPartSample;
            set => canHasPartSample = value;
        }
        
        public Vector3 NextSpawnPosition => nextSpawnPosition;

        public UnityEvent OnDestroyed;

        private void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            if (_transform != null) return;
            
            _transform = transform;
            
            Vector3 position = _transform.position;
            
            nextSpawnPosition += position;
        }

        private void Update()
        {
            if (_isMoving)
                Move();
        }

        private void Move()
        {
            Vector3 shift = Vector3.back * moveSpeed * Time.deltaTime;
            
            _transform.Translate(shift);
            nextSpawnPosition += shift;

            if ((_transform.position - destroyPosition).sqrMagnitude > moveSpeed * Time.deltaTime) return;
            
            OnDestroyed?.Invoke();
            Destroy(gameObject);
        }

        public void GenerateSample(ChunkPart part1, ChunkPart part2)
        {
            if (_transform == null)
                Initialize();
            
            if (!canHasPartSample) return;

            Vector3 position = _transform.position;
            Instantiate(part1, partChunkSampleFirstPosition + position, Quaternion.identity, _transform);
            Instantiate(part2, partChunkSampleSecondPosition + position, Quaternion.identity, _transform);
        }

        public void SpawnTrail(GameObject trail)
        {
            if (_transform == null)
                Initialize();
            
            Instantiate(trail, trail.transform.position, Quaternion.identity, _transform);
        }

        public void StartMoving()
        {
            _isMoving = true;
        }
    }
}