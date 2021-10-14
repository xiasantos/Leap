using UnityEngine;

[CreateAssetMenu(fileName = "Hat Count", menuName = "Scriptable Objects/Hat Count")]
public class CountHats : ScriptableObject
{
    public int hatsCollected;
    public int hatsCollectedCount;
    public string hatId;

    void OnEnable()
    {
        hatsCollected = PlayerPrefs.GetInt(hatId);
    }

    public void AddCount(int amount)
    {
        hatsCollected += amount;
        PlayerPrefs.SetInt(hatId, hatsCollected);
        Debug.Log($"read {PlayerPrefs.GetInt(hatId)}!");
    }
}
