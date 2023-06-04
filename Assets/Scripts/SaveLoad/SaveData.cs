using System.Collections.Generic;
using MessagePack;

namespace Game.Gameplay
{
    [MessagePackObject]
    public class SaveData
    {
        [Key(0)] public int Coins;
        [Key(1)] public int RecordScore;
        [Key(2)] public List<SkinType> Skins;
        [Key(3)] public SkinType SkinNow;
    }
}