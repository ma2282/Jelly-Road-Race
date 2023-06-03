using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class ShopUI : MonoBehaviour
    {
        [SerializeField] private Button exitButton;

        public void Initialize()
        {
            exitButton.onClick.AddListener(ExitSettings);
        }

        private void ExitSettings()
        {
            gameObject.SetActive(false);
        }
    }
}