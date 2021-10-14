using UnityEngine;
using TMPro;

public class HatScore : MonoBehaviour
{
    public CountHats countHatsObject;
    public GameObject hatPanel;
    public TextMeshProUGUI hatScoreText;
    public string frogName;
    public GameObject hatIMG;

    public int valueToCollect;

    private int hats;

    private void OnEnable()
    {
        hats = countHatsObject.hatsCollected;
        hatScoreText.text = $"{hats}/{valueToCollect}";

        if (hats >= valueToCollect)
        {
            hatPanel.SetActive(true);
            hatIMG.SetActive(false);
            hatScoreText.text = $"{frogName}";
        }
    }
}
