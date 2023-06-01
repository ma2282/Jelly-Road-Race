using UnityEngine;

namespace Game.Gameplay
{
    public abstract class HealingObstacle : Obstacle
    {
        [SerializeField] protected float healthPoints;
        
        public override void OnEnterObstacleReceiver(ObstacleReceiver receiver)
        {
            if (receiver.TryGetComponent(out HealthHandler healthHandler))
                Heal(healthHandler);
            base.OnEnterObstacleReceiver(receiver);
        }

        protected virtual void Heal(HealthHandler healthHandler)
        {
            healthHandler.Heal(healthPoints);
        }
    }
}