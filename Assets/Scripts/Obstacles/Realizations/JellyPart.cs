namespace Game.Gameplay
{
    public class JellyPart : HealingObstacle
    {
        private void Start()
        {
            ChangeColor(ColorsManager.Instance.GetRandomColor());
        }
    }
}