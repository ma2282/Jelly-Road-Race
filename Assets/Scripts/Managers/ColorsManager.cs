using System;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Game.Gameplay
{
    public class ColorsManager : Singleton<ColorsManager>
    {
        [SerializeField] private AnimationCurve standardColorGradingCurve;
        [SerializeField] private Renderer[] mainRenderers;
        [SerializeField] private Renderer[] otherRenderers;
        [SerializeField] private PostProcessProfile _postProcessProfile;
        
        private ColorGrading _colorGrading;

        private void Start()
        {
            _colorGrading = _postProcessProfile.settings.Find(x => x is ColorGrading) as ColorGrading;
            ResetColors();
        }

        public void ChangeColor(Color color, AnimationCurve curve)
        {
            foreach (Renderer mainRenderer in mainRenderers)
            {
                Material material = mainRenderer.material;

                if (mainRenderer.gameObject.GetComponentInParent<Player>() != null)
                    color.a = material.color.a;
                
                material.color = color;
            }
            _colorGrading.hueVsSatCurve.value.curve = curve;
        }

        public void ResetColors()
        {
            _colorGrading.hueVsSatCurve.value.curve = standardColorGradingCurve;
        }
    }
}