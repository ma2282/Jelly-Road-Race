using System;
using UnityEngine;

namespace Game.Gameplay
{
    [Serializable]
    public struct GameColor
    {
        public Color Color;
        public AnimationCurve HueVsSaturationCurve;
    }
}