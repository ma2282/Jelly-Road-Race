using MessagePack;

namespace Game
{
    [MessagePackObject]
    public class SaveData
    {
        [Key(0)] public int Coins;
        [Key(1)] public int RecordScore;
    }
}