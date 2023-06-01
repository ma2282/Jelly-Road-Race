using UnityEngine;

namespace Game.Gameplay
{
    public class TrailHandler : MonoBehaviour
    {
        [SerializeField] private Transform trailTransform;

        public void DeactivateTrail()
        {
            ChunkManager.Instance.SpawnTrail(trailTransform.gameObject);
            trailTransform.gameObject.SetActive(false);
        }

        public void ActivateTrail()
        {
            trailTransform.rotation = Quaternion.identity;
            trailTransform.gameObject.SetActive(true);
        }
    }
}