using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Collider), typeof(Renderer))]
    public abstract class Obstacle : MonoBehaviour, IObstacle
    {
        [SerializeField] protected GameColor obstacleColor;
        [SerializeField] protected Renderer _renderer;

        public virtual GameColor Color => obstacleColor;

        public virtual void ChangeColor(GameColor color)
        {
            obstacleColor = color;
            _renderer.material.color = obstacleColor.Color;
        }

        public virtual void OnEnterObstacleReceiver(ObstacleReceiver receiver)
        {
            receiver.ReceiveObstacle(this);
            Destroy(gameObject);
        }
        
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent(out ObstacleReceiver receiver)) return;
                OnEnterObstacleReceiver(receiver);
        }
    }
}