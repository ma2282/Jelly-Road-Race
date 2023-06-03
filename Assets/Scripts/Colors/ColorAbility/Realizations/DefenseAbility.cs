using UnityEngine;

namespace Game.Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay/Abilities/Defense Ability", fileName = "DefenseAbility", order = 0)]
    public class DefenseAbility : ColorAbility
    {
        protected HealthHandler _healthHandler;

        public override void ActivateAbility(GameObject owner)
        {
            base.ActivateAbility(owner);

            if (!owner.TryGetComponent(out _healthHandler)) return;
            
            _healthHandler.RestoreDefense(1);
        }

        public override void DeactivateAbility()
        {
            if (_healthHandler == null) return;
            
            _healthHandler.RemoveDefense(out _);
        }
    }
}