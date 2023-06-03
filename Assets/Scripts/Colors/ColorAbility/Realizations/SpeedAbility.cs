using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay/Abilities/Speed Ability", fileName = "SpeedAbility", order = 0)]
    public class SpeedAbility : ColorAbility
    {
        [SerializeField, Min(0f)] protected float speedRate;
        [SerializeField, Min(0f)] protected float timeSpeedRate;
        
        protected MovementController _movementController;

        public override void ActivateAbility(GameObject owner)
        {
            base.ActivateAbility(owner);

            if (!owner.TryGetComponent(out _movementController)) return;

            _movementController.SpeedRate *= speedRate;
            Time.timeScale *= timeSpeedRate;
        }

        public override void DeactivateAbility()
        {
            if (_movementController == null) return;

            _movementController.SpeedRate /= speedRate;
            Time.timeScale /= timeSpeedRate;
        }
    }
}