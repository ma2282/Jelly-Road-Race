namespace Game.Gameplay
{
    public interface IMovementController
    {
        float MoveSpeed { get; }
        
        void Move(float horizontalMovement);
    }
}