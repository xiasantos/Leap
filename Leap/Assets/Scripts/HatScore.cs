using UnityEngine;
using TMPro;

public class HatScore : MonoBehaviour
{
    public CountHats countHatsObject;
    public GameObject hatPanel;
    public TextMeshProUGUI hatScoreText;

    public int valueToCollect;

    private int hats;

    private void OnEnable()
    {
        hats = countHatsObject.hatsCollected;
        hatScoreText.text = $"{hats}/{valueToCollect}";
        hatPanel.SetActive(hats == valueToCollect);
    }
}
