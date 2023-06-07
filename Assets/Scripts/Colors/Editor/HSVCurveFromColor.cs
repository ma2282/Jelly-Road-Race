using System.Collections.Generic;
using UnityEngine;

namespace Game.Gameplay
{
    public static class HSVCurveFromColor
    {
        private static readonly float[] values = { 0f, 0f, 0.5f, 0.5f, 0f, 0f };
        
        public static AnimationCurve GetHSVCurve(Color color)
        {
            Color.RGBToHSV(color, out float hue, out float saturation, out float value);
            
            float[] times = { 
                0f,
                Mathf.Repeat(hue - 0.15f, 1f),
                Mathf.Repeat(hue - 0.05f, 1f),
                Mathf.Repeat(hue + 0.05f, 1f),
                Mathf.Repeat(hue + 0.15f, 1f),
                1f };

            if (hue is (< 0.15f and > 0.05f) or (> 0.85f and < 0.95f))
                values[0] = values[5] = hue / 2;
            else if (hue is < 0.05f or > 0.95f)
                values[0] = values[5] = 0.5f;
            else
                values[0] = values[5] = 0f;

            Keyframe[] keyframes =
            {
                new (times[0], values[0]),
                new (times[1], values[1]),
                new (times[2], values[2]),
                new (times[3], values[3]),
                new (times[4], values[4]),
                new (times[5], values[5])
            };

            return new AnimationCurve(keyframes);
        }
    }
}