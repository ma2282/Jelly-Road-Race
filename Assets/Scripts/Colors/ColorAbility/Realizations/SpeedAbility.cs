using UnityEngine;

namespace Game.Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay/Abilities/Speed Ability", fileName = "SpeedAbility", order = 0)]
    public class SpeedAbility : ColorAbility
    {
        [SerializeField] private float _speedRate;
        [SerializeField] private float _timeSpeedRate;

        protected float _speedRateBackup;
        protected float _timeSpeedRateBackup;
        protected MovementController _movementController;

        public override void ActivateAbility(GameObject owner)
        {
            base.ActivateAbility(owner);

            if (!owner.TryGetComponent(out _movementController)) return;
            
            _speedRateBackup = _movementController.SpeedRate;
            _timeSpeedRateBackup = Time.timeScale;
            
            _movementController.SpeedRate = _speedRate;
            Time.timeScale = _timeSpeedRate;
        }

        public override void DeactivateAbility()
        {
            if (_movementController == null) return;

            _movementController.SpeedRate = _speedRateBackup;
            Time.timeScale = _timeSpeedRateBackup;
        }
    }
}