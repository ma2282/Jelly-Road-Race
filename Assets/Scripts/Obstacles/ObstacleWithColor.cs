using UnityEngine;

namespace Game.Gameplay
{
    public abstract class ObstacleWithColor : Obstacle
    {
        [SerializeField] protected float healthPoints;
        
        public override void OnEnterObstacleReceiver(GameObject receiverObject, IObstacleReceiver receiver)
        {
            if (receiverObject.TryGetComponent(out HealthHandler healthHandler))
                Heal(healthHandler);
            base.OnEnterObstacleReceiver(receiverObject, receiver);
        }

        protected virtual void Heal(HealthHandler healthHandler)
        {
            healthHandler.Heal(healthPoints);
        }
    }
}