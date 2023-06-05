using System;
using UnityEngine;

namespace Game.Gameplay
{
    [Serializable]
    public class Skin
    {
        public bool IsLocked;
        public int Price;
        public GameObject Object;
        public SkinType Type;
    }
}