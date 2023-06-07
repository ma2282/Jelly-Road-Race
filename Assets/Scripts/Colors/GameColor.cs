using System;
using UnityEditor;
using UnityEngine;

namespace Game.Gameplay
{
    [Serializable]
    public class GameColor : IEquatable<GameColor>
    {
        public Color Color;
        public AnimationCurve HueVsSaturationCurve;
        public ColorAbility ColorAbility;

        public bool Equals(GameColor other)
        {
            return other != null && Color.Equals(other.Color);
        }

        public override bool Equals(object obj)
        {
            return Equals((GameColor)obj);
        }

        public override int GetHashCode()
        {
            return Color.GetHashCode();
        }
    }
}