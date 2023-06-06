using UnityEngine;
    
namespace Game.Gameplay
{
    public class DataPreloader : MonoBehaviour
    {
        [SerializeField] private SaveData defaultData;
        
        private void Start()
        {
            SaveLoadSystem.LoadData();
            PreloadData(SaveLoadSystem.Data);
            GameManager.Instance.GameState = GameState.Stopped;
            Destroy(gameObject);
        }

        private void PreloadData(SaveData data)
        {
            data ??= defaultData;
            
            ValuesManager.Instance.SetCoins(data.Coins);
            ValuesManager.Instance.SetRecordScore(data.RecordScore);
            SkinsManager.Instance.InitializeSkins(data.SkinLockedStates, data.SkinNowType);
        }
    }
}