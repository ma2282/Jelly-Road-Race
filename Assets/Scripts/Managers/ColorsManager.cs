using System.Collections.Generic;
using System.Linq;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class ColorsManager : Singleton<ColorsManager>
    {
        [SerializeField] private GameColor defaultColor;
        [SerializeField] private GameColor[] possibleColors;
        [SerializeField] private Image[] images;
        [SerializeField] private Renderer trailRenderer;
        [SerializeField] private Renderer playerRenderer;
        [SerializeField] private PostProcessProfile _postProcessProfile;
        [SerializeField] private ColorsInventory _mainColorsInventory;
        
        private ColorGrading _colorGrading;

        public GameColor DefaultColor => defaultColor;

        private void Start()
        {
            _colorGrading = _postProcessProfile.settings.Find(x => x is ColorGrading) as ColorGrading;
            ResetColors();
            _mainColorsInventory.OnColorChanged.AddListener(ChangeColor);
        }

        public void ChangeColor(GameColor color)
        {
            ChangeColor(color.Color);

            _colorGrading.hueVsSatCurve.value.curve = color.HueVsSaturationCurve;
        }

        public void ChangeColor(Color color)
        {
            trailRenderer.material.color = color;
            
            Material material = playerRenderer.material;
            material.color = new Color(color.r, color.g, color.b, material.color.a);

            foreach (Image image in images)
                if (image.gameObject.activeInHierarchy)
                    image.color = new Color(color.r, color.g, color.b, image.color.a);
        }

        public void ResetColors()
        {
            ChangeColor(defaultColor);
        }

        public GameColor GetRandomColor()
        {
            return possibleColors[Random.Range(0, possibleColors.Length)];
        }

        public void ChangePlayerRenderer(ReadonlySkin skin)
        {
            playerRenderer = skin.SkinObject.Renderer;
            trailRenderer = skin.SkinObject.TrailRenderer;
        }
    }
}