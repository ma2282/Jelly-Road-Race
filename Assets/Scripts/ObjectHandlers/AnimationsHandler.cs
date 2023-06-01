using System;
using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Animator))]
    public class AnimationsHandler : MonoBehaviour
    {
        private static readonly int DamageTrigger = Animator.StringToHash("TakeDamage");
        private static readonly int HealTrigger = Animator.StringToHash("Heal");
        private static readonly int IdleBool = Animator.StringToHash("IsIdle");

        private Animator _animator;
        
        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        public void TriggerDamage()
        {
            _animator.SetTrigger(DamageTrigger);
        }

        public void TriggerHeal()
        {
            _animator.SetTrigger(HealTrigger);
        }

        public void ActivateIdle()
        {
            _animator.SetBool(IdleBool, true);
        }

        public void DeactivateIdle()
        {
            _animator.SetBool(IdleBool, false);
        }
    }
}