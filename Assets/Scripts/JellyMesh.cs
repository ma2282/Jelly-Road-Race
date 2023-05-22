using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class JellyMesh : MonoBehaviour
    {
        [SerializeField] private float intensity = 1f;
        [SerializeField] private float mass = 1f;
        [SerializeField] private float stiffness = 1f;
        [SerializeField] private float damping = 0.75f;

        private Transform _transform;
        private Mesh _originalMesh, _cloneMesh;
        private MeshRenderer _meshRenderer;
        
        private JellyVertex[] _jellyVertices;
        private Vector3[] _verticesArray;

        private void Start()
        {
            _transform = transform;
            
            _originalMesh = GetComponentInChildren<MeshFilter>().sharedMesh;
            _cloneMesh = Instantiate(_originalMesh);
            GetComponentInChildren<MeshFilter>().sharedMesh = _cloneMesh;
            _meshRenderer = GetComponentInChildren<MeshRenderer>();

            _jellyVertices = new JellyVertex[_cloneMesh.vertices.Length];
            for (int i = 0; i < _cloneMesh.vertices.Length; i++)
                _jellyVertices[i] = new JellyVertex(i, _transform.TransformPoint(_cloneMesh.vertices[i]));
        }

        private void FixedUpdate()
        {
            _verticesArray = _originalMesh.vertices;

            for (int i = 0; i < _jellyVertices.Length; i++)
            {
                Vector3 target = _transform.TransformPoint(_verticesArray[_jellyVertices[i].ID]);
                
                Bounds bounds = _meshRenderer.bounds;
                float intensityNow = (1 - (bounds.max.y - target.y) / bounds.size.y) * this.intensity;
                _jellyVertices[i].Shake(target, mass, stiffness, damping);
                target = _transform.InverseTransformPoint(_jellyVertices[i].Position);
                _verticesArray[_jellyVertices[i].ID] =
                    Vector3.Lerp(_verticesArray[_jellyVertices[i].ID], target, intensityNow);
            }

            _cloneMesh.vertices = _verticesArray;
        }
    }
}

