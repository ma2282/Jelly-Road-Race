using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class HealthHandler : MonoBehaviour
    {
        [SerializeField] private float defaultHealth = 1f;
        [SerializeField] private float health = 1f;
        [SerializeField] private AudioSource healAudio;
        [SerializeField] private AudioSource takeDamageAudio;

        private int _defense;

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

        public int Defense => _defense;

        public void TakeDamage(float damage)
        {
            if (damage < 0f)
                throw new ArgumentException("Damage less than zero");

            if (_defense > 0 && damage > 0f)
                _defense--;
            else
                Health -= damage;

            takeDamageAudio.Play();
            
            OnTakeDamage?.Invoke();
        }

        public void Heal(float healthPoint)
        {
            if (healthPoint < 0f)
                throw new ArgumentException("Health Point less than zero");

            Health += healthPoint;
            
            healAudio.Play();
            
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

        public void RestoreDefense(int defensePoints)
        {
            _defense = defensePoints;
        }

        public void RemoveDefense(out int defensePointsLeft)
        {
            defensePointsLeft = _defense;
            _defense = 0;
        }
    }
}