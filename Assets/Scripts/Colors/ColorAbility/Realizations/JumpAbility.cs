using UnityEngine;

namespace Game.Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay/Abilities/Jump Ability", fileName = "JumpAbility", order = 0)]
    public class JumpAbility : ColorAbility
    {
        [SerializeField] private float _jumpTime;
        [SerializeField] private AnimationCurve _jumpCurve;
        
        protected JumpController _jumpController;

        public override void ActivateAbility(GameObject owner)
        {
            base.ActivateAbility(owner);

            if (!owner.TryGetComponent(out _jumpController)) return;

            _jumpController.Initialize(_jumpTime, _jumpCurve);
            
            _jumpController.Activate();
        }

        public override void DeactivateAbility()
        {
            if (_jumpController == null) return;

            _jumpController.Deactivate();
        }
    }
}