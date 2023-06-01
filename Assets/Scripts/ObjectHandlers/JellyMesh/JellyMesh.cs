using UnityEngine;

namespace Game.Gameplay
{
    public class JellyMesh : MonoBehaviour
    {
        [SerializeField] private float intensity = 1f;
        [SerializeField] private float mass = 1f;
        [SerializeField] private float stiffness = 1f;
        [SerializeField] private float damping = 0.75f;
        [SerializeField] private MeshFilter meshFilter;
        [SerializeField] private MeshRenderer meshRenderer;
        
        private Transform _transform;
        private Mesh _originalMesh, _cloneMesh;

        private Vector3[] _verticesArray;
        private JellyVertex[] _jellyVertices;

        private void Start()
        {
            _transform = transform;

            _originalMesh = meshFilter.sharedMesh;
            _cloneMesh = Instantiate(_originalMesh);
            meshFilter.sharedMesh = _cloneMesh;

            _jellyVertices = new JellyVertex[_cloneMesh.vertices.Length];
            for (int i = 0; i < _cloneMesh.vertices.Length; i++)
                _jellyVertices[i] = new JellyVertex(i, _transform.TransformPoint(_cloneMesh.vertices[i]));
        }

        private void FixedUpdate()
        {
            _verticesArray = _originalMesh.vertices;

            foreach (JellyVertex vertex in _jellyVertices)
            {
                Vector3 target = _transform.TransformPoint(_verticesArray[vertex.ID]);
                
                Bounds bounds = meshRenderer.bounds;
                float intensityNow = (1 - (bounds.max.y - target.y) / bounds.size.y) * intensity;
                vertex.Shake(target, mass, stiffness, damping);
                target = _transform.InverseTransformPoint(vertex.Position);
                _verticesArray[vertex.ID] =
                    Vector3.Lerp(_verticesArray[vertex.ID], target, intensityNow);
            }

            _cloneMesh.vertices = _verticesArray;
        }

        public void Reset()
        {
            _verticesArray = _originalMesh.vertices;
            
            foreach (JellyVertex vertex in _jellyVertices)
            {
                Vector3 target = _transform.TransformPoint(_verticesArray[vertex.ID]);
                vertex.Reset(target);
            }
            
            _cloneMesh.vertices = _verticesArray;
        }
    }
}

