using UnityEngine;

[CreateAssetMenu(fileName = "Hat Count", menuName = "Scriptable Objects/Hat Count")]
public class CountHats : ScriptableObject
{
    public int hatsCollected;
    public int hatsCollectedCount;

    void OnEnable()
    {
        hatsCollected = PlayerPrefs.GetInt("HatsCount", hatsCollected);
    }

    public void AddCount(int amount)
    { 
        hatsCollected += amount;
        Debug.Log($"Add {amount}!");

        PlayerPrefs.SetInt("HatsCount", hatsCollected);
    }
}
