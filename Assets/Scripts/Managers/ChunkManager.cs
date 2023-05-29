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

            InitializeChunks();
        }

        private void InitializeChunks()
        {
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
            newChunk.StartMoving();
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
            Chunk chunk = Instantiate(chunkPrefab, chunks.Count == 0 ? Vector3.zero : chunks.Last().NextSpawnPosition, Quaternion.identity, _transform);
            chunk.Initialize();
            chunks.Add(chunk);
            return chunk;
        }

        public void SpawnTrail(GameObject trail)
        {
            chunks[0].SpawnTrail(trail);
        }

        public void StartMoving()
        {
            foreach (Chunk chunk in chunks)
                chunk.StartMoving();
        }

        public void Reset()
        {
            foreach (Chunk chunk in chunks)
                Destroy(chunk.gameObject);

            chunks = new List<Chunk>();

            Chunk firstChunk = SpawnNewChunk();
            firstChunk.CanHasPartSample = false;
            
            InitializeChunks();
        }
    }
}