using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Game
{
    [RequireComponent(typeof(Slider), typeof(EventTrigger))]
    public class ToggleSlider : MonoBehaviour
    {
        [SerializeField] private Color handleActiveColor;
        [SerializeField] private Color handleNonActiveColor;
        [SerializeField] private Color outlineActiveColor;
        [SerializeField] private Color outlineNonActiveColor;
        [SerializeField] private Slider slider;
        [SerializeField] private Image background;
        [SerializeField] private Image fillArea;
        [SerializeField] private Image handle;

        private const float MIN_VOLUME_DIFFERENCE = 0.1f;
        private Outline _handleOutline;
        
        public UnityEvent<float> onClick;
        
        private void Start()
        {
            if (_handleOutline == null)
                Initialize();
        }

        private void Initialize()
        {
            _handleOutline = handle.GetComponent<Outline>();
            slider.onValueChanged.AddListener(ChangeColor);
            ChangeColor(slider.value);
        }

        public void InitializeValue(float value)
        {
            slider.value = value;
            ChangeColor(value);
        }

        private void ChangeColor(float value)
        {
            if (_handleOutline == null)
                Initialize();
            
            handle.color = value == 0f ? handleNonActiveColor : handleActiveColor;
            _handleOutline.effectColor = value == 0f ? outlineNonActiveColor : handleActiveColor;
        }

        public void OnClick()
        {
            slider.value = slider.value == 0f ? 1f : 0f;
            onClick?.Invoke(slider.value);
        }
    }
}

