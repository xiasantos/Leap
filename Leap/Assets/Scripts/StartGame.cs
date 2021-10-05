using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private Color color;
    private Animator playerAnimator;

    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        color = textComponent.color;
    }



}

