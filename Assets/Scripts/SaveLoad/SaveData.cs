using System;
using System.Collections.Generic;
using MessagePack;

namespace Game.Gameplay
{
    [MessagePackObject]
    [Serializable]
    public class SaveData
    {
        [Key(0)] public int Coins;
        [Key(1)] public int RecordScore;
        [Key(2)] public List<bool> SkinLockedStates;
        [Key(3)] public SkinType SkinNowType;

        public void SetSkinsInfo(SaveData otherData)
        {
            SkinLockedStates = otherData.SkinLockedStates;
            SkinNowType = otherData.SkinNowType;
        }
    }
}