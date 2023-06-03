using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay/Abilities/Jump Ability", fileName = "JumpAbility", order = 0)]
    public class JumpAbility : ColorAbility
    {
        [SerializeField, Min(0f)] protected float jumpTime;
        [SerializeField] protected AnimationCurve jumpCurve;

        protected JumpController _jumpController;

        public override void ActivateAbility(GameObject owner)
        {
            base.ActivateAbility(owner);

            if (!owner.TryGetComponent(out _jumpController)) return;

            _jumpController.Initialize(jumpTime, jumpCurve);
            
            _jumpController.Activate();
        }

        public override void DeactivateAbility()
        {
            if (_jumpController == null) return;

            _jumpController.Deactivate();
        }
    }
}