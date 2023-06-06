using UnityEngine;

namespace Game.Gameplay
{
    public class Player : MonoBehaviour, IObstacleReceiver, IColorAbilityReceiver
    {
        [SerializeField] private MovementController _movementController;
        [SerializeField] private AnimationsHandler _animationsHandler;
        [SerializeField] private HealthHandler _healthHandler;
        [SerializeField] private TrailHandler _trailHandler;
        [SerializeField] private JellyMesh _jellyMesh;
        [SerializeField] private ColorsInventory _colorsInventory;
        [SerializeField] private JumpController _jumpController;

        private ColorAbility _lastColorAbility;

        private void Awake()
        {
            SkinsManager.Instance.OnSkinChanged.AddListener(x => _jellyMesh.SetMeshFromSkin(x));
            SkinsManager.Instance.OnSkinChanged.AddListener(ColorsManager.Instance.ChangePlayerRenderer);
            
            _movementController.OnMovingStart.AddListener(_animationsHandler.DeactivateIdle);
            _movementController.OnMovingEnd.AddListener(_animationsHandler.ActivateIdle);
            
            _movementController.OnMovingStart.AddListener(_trailHandler.DeactivateTrail);
            _movementController.OnMovingEnd.AddListener(_trailHandler.ActivateTrail);
            
            _jumpController.OnJumpingStart.AddListener(_trailHandler.DeactivateTrail);
            _jumpController.OnJumpingEnd.AddListener(_trailHandler.ActivateTrail);
            
            _healthHandler.OnHeal.AddListener(_animationsHandler.TriggerHeal);
            _healthHandler.OnTakeDamage.AddListener(_animationsHandler.TriggerDamage);
            
            _healthHandler.OnKilled.AddListener(() => GameManager.Instance.GameState = GameState.Finished);
            
            _colorsInventory.Reset(this);
        }

        public void Reset()
        {
            _healthHandler.Reset();
            _colorsInventory.Reset(this);
            _movementController.ResetPosition();
            _movementController.ResetParams();
            _jellyMesh.Reset();
        }

        public void ReceiveObstacle(IObstacle obstacle)
        {
            if (obstacle is not ObstacleWithColor) return;
            
            _colorsInventory.AddColor(obstacle.Color);
            ValuesManager.Instance.Coins++;
        }

        public void ReceiveColorAbility(ColorAbility ability)
        {
            if (_lastColorAbility != null)
                _lastColorAbility.DeactivateAbility();

            if (ability != null)
            {
                ability.ActivateAbility(gameObject);
                
                if (_lastColorAbility == ability)
                    ability.RestoreDefaults();
            }

            _lastColorAbility = ability;
        }
    }
}