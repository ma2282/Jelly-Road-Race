namespace Game.Gameplay
{
    public interface IObstacle
    {
        GameColor Color { get; }

        void ChangeColor(GameColor color);
        
        void OnEnterObstacleReceiver(ObstacleReceiver receiver);
    }
}