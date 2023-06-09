using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

namespace Game.Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay/Skin", fileName = "Skin", order = 0)]
    public class Skin : ScriptableObject
    {
        public bool IsLocked;
        public int Price;
        public SkinType Type;
        public Sprite Sprite;
        public SkinObject Prefab;
    }
}