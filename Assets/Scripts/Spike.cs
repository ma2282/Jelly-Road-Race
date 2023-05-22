using System;
using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Collider))]
    public class Spike : MonoBehaviour
    {
        [SerializeField] private float damage;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent(out Player player)) return;
            
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}