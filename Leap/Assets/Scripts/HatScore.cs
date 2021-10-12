using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HatScore : MonoBehaviour
{
    public TextMeshProUGUI hatScoreText;
    public GameObject hatPanel;

    public CountHats countHatsObject;
    public int valueToCollect;

    private int hats;

    private void Start()
    {
        countHatsObject.hatsCollected = hats;
    }
    private void FixedUpdate()
    {
        hatScoreText.text = $"{hats}/{valueToCollect}";

        if (hats == valueToCollect)
        {
            hatPanel.SetActive(true);
        }
  
    }

}

    

 

