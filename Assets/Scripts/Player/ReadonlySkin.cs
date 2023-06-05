using UnityEngine;

namespace Game.Gameplay
{
    public struct ReadonlySkin
    {
        public bool IsLocked;
        public int Price;
        public MeshRenderer Renderer;
        public MeshFilter Filter;
        public SkinType Type;
        
        public ReadonlySkin(Skin skin)
        {
            IsLocked = skin.IsLocked;
            Price = skin.Price;
            Type = skin.Type;
            Renderer = skin.Object.GetComponent<MeshRenderer>();
            Filter = skin.Object.GetComponent<MeshFilter>();
        }
    }
}