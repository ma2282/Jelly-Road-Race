using UnityEngine;

namespace Game.Gameplay
{
    public abstract class DamagingObstacle : Obstacle
    {
        [SerializeField] protected float healthPoints;
        
        public override void OnEnterObstacleReceiver(ObstacleReceiver receiver)
        {
            if (receiver.TryGetComponent(out HealthHandler healthHandler))
                TakeDamage(healthHandler);
            base.OnEnterObstacleReceiver(receiver);
        }

        protected virtual void TakeDamage(HealthHandler healthHandler)
        {
            healthHandler.TakeDamage(healthPoints);
        }
    }
}