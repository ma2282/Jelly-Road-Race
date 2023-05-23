using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Collider))]
    public class JellyPart : MonoBehaviour
    {
        [SerializeField] private float healthPoint;
        [SerializeField] private Color color;
        [SerializeField] private AnimationCurve curve;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent(out Player player)) return;
            
            player.Heal(healthPoint);
            ColorsManager.Instance.ChangeColor(color, curve);
            Destroy(gameObject);
        }
    }
}