using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Collider))]
    public class JellyPart : MonoBehaviour
    {
        [SerializeField] private float healthPoint;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent(out Player player)) return;
            
            player.Heal(healthPoint);
            Destroy(gameObject);
        }
    }
}