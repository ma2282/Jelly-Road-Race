using UnityEngine;

namespace Game.Gameplay
{
    public abstract class ObstacleReceiver : MonoBehaviour, IObstacleReceiver
    {
        public abstract void ReceiveObstacle(IObstacle obstacle);
    }
}