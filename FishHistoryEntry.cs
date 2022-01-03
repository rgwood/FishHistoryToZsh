public class FishHistoryEntry
{
    public string cmd;
    public int when;

    public DateTimeOffset Timestamp => DateTimeOffset.FromUnixTimeSeconds(when);
}