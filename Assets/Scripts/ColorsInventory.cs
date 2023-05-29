using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Gameplay
{
    public class ColorsInventory
    {
        private int _indexNow;
        private List<GameColor> _colors;

        public ColorsInventory()
        {
            _colors = new List<GameColor>(4) { ColorsManager.Instance.DefaultColor };
        }

        public void AddColor(GameColor color)
        {
            if (_colors.Contains(color))
            {
                ChangeIndex(GetColorIndex(color));
                
                ApplyColor();
            }
            else
            {
                _colors.Add(color);

                ChangeIndex(GetColorIndex(color));
                
                ApplyColor();
            }
        }

        public GameColor GetColor(int shift = 0)
        {
            ChangeIndexByShift(shift);
            
            return _colors[_indexNow];
        }

        public void ChangeIndexByShift(int shift)
        {
            if (shift == 0)
                return;
            
            int index = (_indexNow + shift) % _colors.Count;
            index = (index < 0) ? _colors.Count - 1 : index;

            _indexNow = index;
        }
        
        public void ChangeIndex(int index)
        {
            _indexNow = index;
        }

        public int GetColorIndex(GameColor color)
        {
            return _colors.IndexOf(color);
        }

        public void ApplyColor()
        {
            ColorsManager.Instance.ChangeColor(GetColor());
        }
    }
}