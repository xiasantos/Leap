using UnityEngine;
using TMPro;

public class HatsPanel : MonoBehaviour
{
    public GameObject hatsPanel;
    public GameObject HUDPanel;
    public GameObject playTXT;
    public GameObject player;
    //public TextMeshProUGUI strawberryTXT;
    //public TextMeshProUGUI dragonflyTXT;
    //public TextMeshProUGUI flowerTXT;
    //public TextMeshProUGUI cowboyTXT;
    public Animator frogAnimator;
    public AnimatorProvider flower;
    public AnimatorProvider cowboy;
    public AnimatorProvider dragonfly;
    public AnimatorProvider strawberry;



    public void Open()
    {
        hatsPanel.SetActive(true);
        HUDPanel.SetActive(false);
        playTXT.SetActive(false);

    }

    public void Back()
    {
        hatsPanel.SetActive(false);
        HUDPanel.SetActive(true);
        playTXT.SetActive(true);
    }
}