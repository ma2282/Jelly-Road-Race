using UnityEngine;

namespace Game.Gameplay
{
    public class DataPreloader : MonoBehaviour
    {
        private void Start()
        {
            SaveLoadSystem.LoadData();
            PreloadData(SaveLoadSystem.Data);
            Destroy(gameObject);
        }

        private void PreloadData(SaveData data)
        {
            if (data == null) return;
            
            ValuesManager.Instance.SetCoins(data.Coins);
            ValuesManager.Instance.SetRecordScore(data.RecordScore);
        }
    }
}