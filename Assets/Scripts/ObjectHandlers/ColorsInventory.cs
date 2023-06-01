using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class ColorsInventory : MonoBehaviour
    {
        private int _indexNow;
        private List<GameColor> _colors;

        private IColorAbilityReceiver _colorAbilityReceiver;

        public UnityEvent<GameColor> OnColorChanged;
        public UnityEvent<GameColor> OnTakeNewColor;

        private void Initialize(IColorAbilityReceiver receiver = null)
        {
            _indexNow = 0;
            _colors = new List<GameColor>(4) { ColorsManager.Instance.DefaultColor };
            _colorAbilityReceiver = receiver;
        }

        public void AddColor(GameColor color)
        {
            if (!_colors.Contains(color))
            {
                _colors.Add(color);
                OnTakeNewColor?.Invoke(color);
            }

            ChangeIndex(GetColorIndex(color));
        }

        private void ChangeIndex(int index)
        {
            _indexNow = index;
            
            OnColorChanged?.Invoke(_colors[_indexNow]);
            
            _colorAbilityReceiver.ReceiveColorAbility(_colors[_indexNow].ColorAbility);
        }

        public void ShiftColor(int shift)
        {
            if (shift == 0)
                return;
            
            int index = (_indexNow + shift) % _colors.Count;
            index = (index < 0) ? _colors.Count - 1 : index;
            
            ChangeIndex(index);
        }

        private int GetColorIndex(GameColor color)
        {
            return _colors.IndexOf(color);
        }

        public void Reset()
        {
            Initialize();
        }
        
        public void Reset(IColorAbilityReceiver receiver)
        {
            Initialize(receiver);
        }
    }
}