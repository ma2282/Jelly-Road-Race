using UnityEngine;

namespace Game.Gameplay
{
    public struct ReadonlySkin
    {
        public readonly bool IsLocked;
        public readonly int Price;
        public readonly SkinType Type;
        public readonly Sprite Sprite;
        public readonly SkinObject SkinObject;

        public ReadonlySkin(Skin skin, SkinObject skinObject = null)
        {
            IsLocked = skin.IsLocked;
            Price = skin.Price;
            Type = skin.Type;
            Sprite = skin.Sprite;
            SkinObject = skinObject;
        }
    }
}