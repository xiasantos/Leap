using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DragonflyAnimation : MonoBehaviour
{
    void OnEnable()
    {
        transform.DOShakePosition(1, new Vector3(1,1,0), 3, 40, false, false)
             .SetLoops(10, LoopType.Yoyo)
             .SetId("dragonfly")
             .ManualUpdate(1.0f, 1.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Border"))
        {
            DOTween.Kill("dragonfly");
        }
    }
}