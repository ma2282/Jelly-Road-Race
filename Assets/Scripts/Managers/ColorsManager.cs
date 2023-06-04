using NTC.Global.System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class ColorsManager : Singleton<ColorsManager>
    {
        [SerializeField] private GameColor defaultColor;
        [SerializeField] private GameColor[] possibleColors;
        [SerializeField] private Image fogImage;
        [SerializeField] private Renderer playerRenderer;
        [SerializeField] private Renderer[] mainRenderers;
        [SerializeField] private PostProcessProfile _postProcessProfile;
        [SerializeField] private ColorsInventory _mainColorsInventory;
        [SerializeField] private SkinHandler _skinHandler;
        
        private ColorGrading _colorGrading;

        public GameColor DefaultColor => defaultColor;

        private void Start()
        {
            _colorGrading = _postProcessProfile.settings.Find(x => x is ColorGrading) as ColorGrading;
            ResetColors();
            _mainColorsInventory.OnColorChanged.AddListener(ChangeColor);
            _skinHandler.OnSkinChanged.AddListener(ChangePlayerRenderer);
        }

        public void ChangeColor(GameColor color)
        {
            foreach (Renderer mainRenderer in mainRenderers)
            {
                Material material = mainRenderer.material;
                
                material.color = color.Color;
            }

            Material playerMaterial = playerRenderer.material;
            
            Color resultColor = color.Color;
            resultColor.a = playerMaterial.color.a;
            playerMaterial.color = resultColor;

            Color fogColor = color.Color;
            fogColor.a = fogImage.color.a;
            
            fogImage.color = fogColor;

            _colorGrading.hueVsSatCurve.value.curve = color.HueVsSaturationCurve;
        }

        public void ResetColors()
        {
            _colorGrading.hueVsSatCurve.value.curve = defaultColor.HueVsSaturationCurve;
        }

        public GameColor GetRandomColor()
        {
            return possibleColors[Random.Range(0, possibleColors.Length)];
        }

        public void ChangePlayerRenderer(Skin skin)
        {
            playerRenderer = skin.SkinObject.GetComponent<Renderer>();
        }
    }
}