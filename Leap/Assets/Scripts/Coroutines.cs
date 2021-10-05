using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public static class Coroutines
{
    public static IEnumerator FadeInCanvasGroupAlpha(
        CanvasGroup canvasGroup, float from, float to, float duration)
    {
        canvasGroup.gameObject.SetActive(true);

        yield return FadeCanvasGroupAlpha(canvasGroup, from, to, duration);
    }

    public static IEnumerator FadeOutCanvasGroupAlpha(
        CanvasGroup canvasGroup, float from, float to, float duration)
    {
        yield return FadeCanvasGroupAlpha(canvasGroup, from, to, duration);
        canvasGroup.gameObject.SetActive(false);
    }

    public static IEnumerator FadeCanvasGroupAlpha(
        CanvasGroup canvasGroup, float from, float to, float duration)
    {
        var timer = 0f;
        while (timer <= duration)
        {
            timer += Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(from, to, timer / duration);

            yield return null;
        }

        canvasGroup.alpha = to;
    }

    public static IEnumerator
        LerpToColor(Graphic target, Color32 from, Color32 to, float duration)
    {
        var originalColor = target.color;
        var timer = 0.0f;
        while (timer < duration)
        {
            target.color = Color32.Lerp(from, to, timer);
            timer += Time.unscaledDeltaTime / duration;

            yield return null;
        }

        target.color = originalColor;
    }

    public static IEnumerator CycleColor(
        Graphic target, Color32 from, Color32 to,
        float interval = 1.0f, float speed = 1.0f, float timeout = 10.0f)
    {
        var originalColor = target.color;
        var startTime = Time.realtimeSinceStartup;

        while (Time.realtimeSinceStartup < timeout + startTime)
        {
            var animationTimer = 0.0f;
            while (animationTimer < interval)
            {
                target.color = Color32.Lerp(from, to, animationTimer);
                animationTimer += Time.unscaledDeltaTime * speed;

                yield return null;
            }

            (from, to) = (to, from);

            yield return null;
        }

        target.color = originalColor;
    }
}