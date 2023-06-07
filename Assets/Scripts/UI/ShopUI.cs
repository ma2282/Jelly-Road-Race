using System;
using DanielLochner.Assets.SimpleScrollSnap;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class ShopUI : UICanvas
    {
        [SerializeField] private Color lockedSkinColor = Color.black;
        [SerializeField] private Button exitButton;
        [SerializeField] private Button selectSkinButton;
        [SerializeField] private Button unlockSkinButton;
        [SerializeField] private TextMeshProUGUI unlockText;
        [SerializeField] private Button buyCoins1Button;
        [SerializeField] private SimpleScrollSnap scrollSnap;
        [SerializeField] private Image[] skins;
        [SerializeField] private TextMeshProUGUI coinsText;

        private int _skinNowIndex;
        private int _skinNowPrice;

        private void Start()
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(coinsText.rectTransform);
        }

        public override void Initialize()
        {
            exitButton.onClick.AddListener(Close);
            buyCoins1Button.onClick.AddListener(ShowAd);
            scrollSnap.OnPanelSelected.AddListener(SetSkinIndex);
            selectSkinButton.onClick.AddListener(SelectSkin);
            unlockSkinButton.onClick.AddListener(TryUnlockSkin);

            unlockSkinButton.gameObject.SetActive(false);
            
            for (int i = 0; i < skins.Length; i++)
                skins[i].color = SkinsManager.Instance.GetSkin(i).IsLocked ? lockedSkinColor : Color.white;
        }

        private void ShowAd()
        {
            RewardedAd.Ad.ShowAd(AdType.OneCoinsAd);
        }

        private void TryUnlockSkin()
        {
            if (ValuesManager.Instance.Coins < _skinNowPrice) return;
            
            SkinsManager.Instance.UnlockSkin(_skinNowIndex);
            ValuesManager.Instance.Coins -= _skinNowPrice;
            
            unlockSkinButton.gameObject.SetActive(false);
            skins[_skinNowIndex].color = Color.white;
        }

        private void SetSkinIndex(int index)
        {
            _skinNowIndex = index;
            unlockSkinButton.gameObject.SetActive(SkinsManager.Instance.GetSkin(index).IsLocked);
            
            _skinNowPrice = SkinsManager.Instance.GetSkin(index).Price;
            unlockText.text = _skinNowPrice.ToString();
        }

        private void SelectSkin()
        {
            SkinsManager.Instance.SetSkin(_skinNowIndex);
        }

        public void ChangeCoins(int coins)
        {
            coinsText.text = coins.ToString();
        }
    }
}