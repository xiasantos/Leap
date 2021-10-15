using UnityEngine;
using DG.Tweening;

public class LeafMove : MonoBehaviour
{
    void OnEnable()
    {
        transform.DOBlendableMoveBy(new Vector3 (4,1,0),3)
             .SetLoops(10, LoopType.Yoyo)
             .SetEase(Ease.InCirc)
             .SetId("leaf")
             .ManualUpdate(1.0f, 1.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Border"))
        {
            DOTween.Kill("leaf");
        }
    }
}
