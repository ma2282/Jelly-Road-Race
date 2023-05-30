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

        public UnityEvent<float> onClick;
        
        private void Start()
        {
            slider.onValueChanged.AddListener(ChangeColor);
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

