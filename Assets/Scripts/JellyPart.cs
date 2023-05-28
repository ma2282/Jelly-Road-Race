using System;
using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Collider))]
    public class JellyPart : MonoBehaviour
    {
        [SerializeField] private float healthPoint;
        
        private GameColor _color;
        
        private Renderer _renderer;

        private void Start()
        {
            _color = ColorsManager.Instance.GetRandomColor();

            _renderer = GetComponent<Renderer>();
            
            _renderer.material.color = _color.Color;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent(out Player player)) return;
            
            player.Heal(healthPoint);
            player.ChangeColor(_color);
            ValuesManager.Instance.AddCoins(1);
            Destroy(gameObject);
        }
    }
}