using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Gameplay
{
    public class ChunkManager : MonoBehaviour
    {
        [SerializeField] private int maxChunksCount;

        [SerializeField] private Chunk chunkPrefab;
        [SerializeField] private List<Chunk> chunks;

        private Transform _transform;
        
        private void Start()
        {
            _transform = GetComponent<Transform>();

            while (chunks.Count < maxChunksCount)
                SpawnNewChunk();
            
            foreach (Chunk chunk in chunks)
                chunk.OnDestroyed.AddListener(OnChunkDestroyed);
        }

        private void OnChunkDestroyed()
        {
            chunks.RemoveAt(0);
            SpawnNewChunk().OnDestroyed.AddListener(OnChunkDestroyed);
        }

        private Chunk SpawnNewChunk()
        {
            Chunk chunk = Instantiate(chunkPrefab, chunks.Last().NextSpawnPosition, Quaternion.identity, _transform);
            chunks.Add(chunk);
            return chunk;
        }
    }
}