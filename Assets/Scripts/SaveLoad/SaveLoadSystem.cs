using System.IO;
using MessagePack;
using UnityEngine;

namespace Game
{
    public static class SaveLoadSystem
    {
        private const string saveFileName = "save.dat";

        public static SaveData Data { get; private set; }

        public static void SaveData(SaveData data = null)
        {
            data ??= Data;
            
            string filePath = Path.Combine(Application.persistentDataPath, saveFileName);
            byte[] saveBytes = MessagePackSerializer.Serialize(data);
            File.WriteAllBytes(filePath, saveBytes);
            Debug.Log("Save successful");
        }
        
        public static void LoadData()
        {
            string filePath = Path.Combine(Application.persistentDataPath, saveFileName);
            
            if (!File.Exists(filePath))
                return;
            
            byte[] saveBytes = File.ReadAllBytes(filePath);
            SaveData data = MessagePackSerializer.Deserialize<SaveData>(saveBytes);
            Data = data;
            Debug.Log("Load successful");
        }
    }
}
