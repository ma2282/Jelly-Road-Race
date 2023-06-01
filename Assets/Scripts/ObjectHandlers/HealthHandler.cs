using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class HealthHandler : MonoBehaviour
    {
        [SerializeField] private float defaultHealth = 1f;
        [SerializeField] private float health = 1f;

        public UnityEvent OnHeal;
        public UnityEvent OnTakeDamage;
        public UnityEvent OnKilled;
        
        public float Health
        {
            get => health;
            private set
            {
                if (value <= 0f || health <= 0f)
                    Kill();
                else
                    health = value;
            }
        }
        
        public void TakeDamage(float damage)
        {
            if (damage < 0f)
                throw new ArgumentException("Damage less than zero");

            Health -= damage;
            
            OnTakeDamage?.Invoke();
        }

        public void Heal(float healthPoint)
        {
            if (healthPoint < 0f)
                throw new ArgumentException("Health Point less than zero");

            Health += healthPoint;
            
            OnHeal?.Invoke();
        }
        
        public void Kill()
        {
            health = 0f;
            OnKilled?.Invoke();
        }

        public void Reset()
        {
            health = defaultHealth;
        }
    }
}