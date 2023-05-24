using System;
using System.Collections.Generic;
using System.Linq;
using NTC.Global.System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Gameplay
{
    public class ChunkManager : Singleton<ChunkManager>
    {
        [SerializeField] private int maxChunksCount;
        
        [SerializeField] private Chunk chunkPrefab;
        [SerializeField] private List<Chunk> chunks;
        [SerializeField] private List<ChunkPart> chunkPartSamples;

        private Transform _transform;
        
        private void Start()
        {
            _transform = GetComponent<Transform>();

            while (chunks.Count < maxChunksCount)
                SpawnNewChunk();

            foreach (Chunk chunk in chunks)
                InitializeChunk(chunk);
        }

        private void OnChunkDestroyed()
        {
            chunks.RemoveAt(0);
            Chunk newChunk = SpawnNewChunk();
            InitializeChunk(newChunk);
        }

        private void InitializeChunk(Chunk chunk)
        {
            chunk.OnDestroyed.AddListener(OnChunkDestroyed);
            chunk.GenerateSample(
                chunkPartSamples[Random.Range(0, chunkPartSamples.Count)], 
                chunkPartSamples[Random.Range(0, chunkPartSamples.Count)]);
        }

        private Chunk SpawnNewChunk()
        {
            Chunk chunk = Instantiate(chunkPrefab, chunks.Last().NextSpawnPosition, Quaternion.identity, _transform);
            chunk.Initialize();
            chunks.Add(chunk);
            return chunk;
        }

        public void SpawnTrail(GameObject trail)
        {
            chunks[0].SpawnTrail(trail);
        }
    }
}