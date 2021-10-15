using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

[CreateAssetMenu(fileName = "Point Animation", menuName = "Scriptable Objects/Point Animation")]

public class PointAnimation : ScriptableObject
{
    public TextMesh pointText;
    public int points;

    public void Animate()
    {
        pointText.text = $"+{points}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(pointText.gameObject);
        }
    }
}