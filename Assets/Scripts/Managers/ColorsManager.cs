using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class ColorsManager : Singleton<ColorsManager>
    {
        [SerializeField] private Renderer[] mainRenderers;
        [SerializeField] private Renderer[] otherRenderers;

        public void ChangeColor()
        {
            Color color = new (Random.value, Random.value, Random.value);

            foreach (Renderer mainRenderer in mainRenderers)
            {
                mainRenderer.material.color = color;
            }
        }
    }
}