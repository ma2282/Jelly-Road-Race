using UnityEngine;
using UnityEngine.Advertisements;

namespace Game.Gameplay
{
    public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener
    {
        [SerializeField] private bool isTestMod;
        [SerializeField] private string androidGameId;
        [SerializeField] private string iosGameId;
        
        private string gameId;

        private void Awake()
        {
            InitializeAds();
        }

        public void InitializeAds()
        {
            gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
                ? iosGameId
                : androidGameId;
            
            Advertisement.Initialize(gameId, isTestMod, this);
        }

        public void OnInitializationComplete()
        {
        }

        public void OnInitializationFailed(UnityAdsInitializationError error, string message)
        {
        }
    }
}
