using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HatsPanel : MonoBehaviour
{
    public GameObject hatsPanel;
    public GameObject HUDPanel;
    public GameObject playTXT;
    public GameObject player;

    public Sprite ogSprite;
    public Sprite cowboySprite;
    public Sprite flowerSprite;
    public Sprite dragonflySprite;
    public Sprite strawberrySprite;

    public AnimatorProvider ogProvider;
    public AnimatorProvider cowboyProvider;
    public AnimatorProvider flowerProvider;
    public AnimatorProvider dragonflyProvider;
    public AnimatorProvider strawberryProvider;


    private int activeSpriteIndex = 0;

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


    public void ChangeAnimatorOG()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = ogProvider.animatorController;
        player.GetComponent<SpriteRenderer>().sprite = ogSprite;
    }

    public void ChangeAnimatorCowboy()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = cowboyProvider.animatorController;
        player.GetComponent<SpriteRenderer>().sprite = cowboySprite;
    }

    public void ChangeAnimatorFlower()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = flowerProvider.animatorController;
        player.GetComponent<SpriteRenderer>().sprite = flowerSprite;
    }

    public void ChangeAnimatorDragonfly()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = dragonflyProvider.animatorController;
        player.GetComponent<SpriteRenderer>().sprite = dragonflySprite;
    }

    public void ChangeAnimatorStrawberry()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = strawberryProvider.animatorController;
        player.GetComponent<SpriteRenderer>().sprite = strawberrySprite;
    }


       
    }