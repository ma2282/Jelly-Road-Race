using UnityEngine;

namespace Game.Gameplay
{
    public abstract class DamagingObstacle : Obstacle
    {
        [SerializeField] protected float healthPoints;
        
        public override void OnEnterObstacleReceiver(GameObject receiverObject, IObstacleReceiver receiver)
        {
            if (receiverObject.TryGetComponent(out HealthHandler healthHandler))
                TakeDamage(healthHandler);
            if (receiverObject.TryGetComponent(out ColorsInventory colorsInventory))
                colorsInventory.RemoveColorNow();
            base.OnEnterObstacleReceiver(receiverObject, receiver);
        }

        protected virtual void TakeDamage(HealthHandler healthHandler)
        {
            healthHandler.TakeDamage(healthPoints);
        }
    }
}