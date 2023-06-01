using UnityEngine;

namespace Game.Gameplay
{
    public interface IObstacle
    {
        GameColor Color { get; }

        void ChangeColor(GameColor color);
        
        void OnEnterObstacleReceiver(GameObject receiverObject, IObstacleReceiver receiver);
    }
}