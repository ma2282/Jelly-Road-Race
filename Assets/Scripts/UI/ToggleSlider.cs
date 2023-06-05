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
        [SerializeField] private Slider slider;
        [SerializeField] private Image background;
        [SerializeField] private Image fillArea;
        [SerializeField] private Image handle;

        private const float MIN_VOLUME_DIFFERENCE = 0.1f;
        
        public UnityEvent<float> onClick;
        
        private void Start()
        {
            slider.onValueChanged.AddListener(ChangeColor);
        }

        public void InitializeValue(float value)
        {
            slider.value = value;
            ChangeColor(value);
        }

        private void ChangeColor(float value)
        {
            handle.color = value == 0f ? background.color : fillArea.color;
        }

        public void OnClick()
        {
            slider.value = slider.value == 0f ? 1f : 0f;
            onClick?.Invoke(slider.value);
        }
    }
}

