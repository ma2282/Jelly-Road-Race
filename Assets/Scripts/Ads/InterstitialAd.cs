using UnityEngine;
using UnityEngine.Advertisements;

namespace Game.Gameplay
{
    public class InterstitialAd : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
    {
        [SerializeField] private string androidAdUnityId = "Interstitial_Android";
        [SerializeField] private string iosAdUnityId = "Interstitial_iOS";
        
        private string _adUnityId;

        public static InterstitialAd Ad;
        
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

        public void ShowAd()
        {
            Advertisement.Show(_adUnityId, this);
        }

        public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
        {
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

