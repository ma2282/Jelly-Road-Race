using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class ShopUI : MonoBehaviour
    {
        [SerializeField] private Button exitButton;
        [SerializeField] private Button selectSkinButton;
        [SerializeField] private Button buyCoins1Button;
        [SerializeField] private SimpleScrollSnap scrollSnap;
        [SerializeField] private SkinHandler skinHandler;

        private int _skinNowIndex;
        
        public void Initialize()
        {
            exitButton.onClick.AddListener(ExitSettings);
            buyCoins1Button.onClick.AddListener(Show1Add);
            scrollSnap.OnPanelSelected.AddListener(SetSkinIndex);
            selectSkinButton.onClick.AddListener(SelectSkin);
        }

        private void ExitSettings()
        {
            gameObject.SetActive(false);
        }

        private void Show1Add()
        {
            RewardedAd.Ad.ShowAd(AdType.OneCoinsAd);
        }

        private void SetSkinIndex(int index)
        {
            _skinNowIndex = index;
        }

        private void SelectSkin()
        {
            skinHandler.SetSkin((SkinType)_skinNowIndex);
        }
    }
}