using UnityEngine;

namespace Game.Gameplay
{
    public class GameplayPreloader : MonoBehaviour
    {
        private void Start()
        {
            SaveLoadSystem.LoadData();
            Preload(SaveLoadSystem.Data);
            Destroy(gameObject);
        }

        private void Preload(SaveData data)
        {
            if (data == null) return;
            
            ValuesManager.Instance.SetCoins(data.Coins);
            ValuesManager.Instance.SetRecordScore(data.RecordScore);
            SkinsManager.Instance.InitializeSkins(data.SkinLockedStates, data.SkinNowType);
        }
    }
}