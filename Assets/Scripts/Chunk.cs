using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class Chunk : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        
        [SerializeField] private Vector3 nextSpawnPosition;
        [SerializeField] private Vector3 destroyPosition;
        [SerializeField] private Vector3 partChunkSampleFirstPosition;
        [SerializeField] private Vector3 partChunkSampleSecondPosition;

        private Transform _transform;

        public Vector3 NextSpawnPosition => nextSpawnPosition;

        public UnityEvent OnDestroyed;
        
        private void Start()
        {
            _transform = GetComponent<Transform>();
            
            Vector3 position = _transform.position;
            
            nextSpawnPosition += position;
            partChunkSampleFirstPosition += position;
            partChunkSampleSecondPosition += position;
        }

        private void Update()
        {
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
            Instantiate(part1, partChunkSampleFirstPosition, Quaternion.identity, _transform);
            Instantiate(part2, partChunkSampleSecondPosition, Quaternion.identity, _transform);
        }
    }
}