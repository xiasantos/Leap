using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour
{ 
    void Start()
    {
        Sequence pulseFade = DOTween.Sequence();

        pulseFade.Join(transform.DOScale(1.2f, 1f))
            .Append(transform.DOScale(1f, 0.5f))
            .SetId("pulseFade")
            .OnComplete(Start);
    }  

}
