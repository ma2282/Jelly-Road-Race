namespace Game.Gameplay
{
    public class JellyPart : ObstacleWithColor
    {
        private void Start()
        {
            ChangeColor(ColorsManager.Instance.GetRandomColor());
        }
    }
}