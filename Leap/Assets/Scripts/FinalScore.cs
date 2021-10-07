using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI score;

    public void SetScore(string txt)
    { score.text = txt;
    }



}
