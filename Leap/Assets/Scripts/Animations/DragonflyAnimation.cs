using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DragonflyAnimation : MonoBehaviour
{
    void OnEnable()
    {
        transform.DOShakePosition(1, 1, 3, 90, false, true)
             .SetLoops(10, LoopType.Restart)
             .SetId("dragonfly")
             .ManualUpdate(1.0f, 1.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DOTween.Kill("dragonfly");
        }
    }
}