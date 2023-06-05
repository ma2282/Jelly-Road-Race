using System;
using UnityEngine;
using UnityEngine.Advertisements;

namespace Game.Gameplay
{
    public class RewardedAd : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
    {
        [SerializeField] private string androidAdUnityId = "Rewarded_Android";
        [SerializeField] private string iosAdUnityId = "Rewarded_iOS";
        [SerializeField] private int oneAdReward = 250;
        [SerializeField] private int twoAdReward = 600;
        
        private AdType _type;
        private string _adUnityId;

        public static RewardedAd Ad;
        
        private void Awake()
        {
            Ad = this;
            _adUnityId = (Application.platform == RuntimePlatform.IPhonePlayer)
                ? iosAdUnityId
                : androidAdUnityId;

            LoadAd();
        }

        public void LoadAd()
        {
            Advertisement.Load(_adUnityId, this);
        }

        public void ShowAd(AdType type)
        {
            Advertisement.Show(_adUnityId, this);
            _type = type;

        }

        public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
        {
            if (!placementId.Equals(_adUnityId) || showCompletionState != UnityAdsShowCompletionState.COMPLETED) return;
            
            switch (_type)
            {
                case AdType.OneCoinsAd:
                    ValuesManager.Instance.Coins += oneAdReward;
                    break;
                case AdType.TwoCoinsAd:
                    ValuesManager.Instance.Coins += twoAdReward;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            LoadAd();
        }
        
        public void OnUnityAdsAdLoaded(string placementId)
        {
        }

        public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
        {
        }

        public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
        {
        }

        public void OnUnityAdsShowStart(string placementId)
        {
        }

        public void OnUnityAdsShowClick(string placementId)
        {
        }
    }
}