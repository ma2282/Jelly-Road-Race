using UnityEngine;

namespace Game.Gameplay
{
    public class Player : MonoBehaviour, IObstacleReceiver, IColorAbilityReceiver
    {
        [SerializeField] private MovementController _movementController;
        [SerializeField] private HealthHandler _healthHandler;
        [SerializeField] private ColorsInventory _colorsInventory;
        [SerializeField] private JumpController _jumpController;

        private ColorAbility _lastColorAbility;

        private void Awake()
        {
            SkinsManager.Instance.OnSkinChanged.AddListener(ColorsManager.Instance.ChangePlayerRenderer);
            SkinsManager.Instance.OnSkinChanged.AddListener(_movementController.SetSkinObject);

            _healthHandler.OnKilled.AddListener(() => GameManager.Instance.GameState = GameState.Finished);
            
            _colorsInventory.Reset(this);
        }

        public void Reset()
        {
            _healthHandler.Reset();
            _colorsInventory.Reset(this);
            _movementController.ResetPosition();
            _movementController.ResetParams();
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