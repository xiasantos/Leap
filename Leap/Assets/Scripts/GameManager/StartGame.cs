using UnityEngine;
using TMPro;
using System;
using DG.Tweening;

public class StartGame : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject star;
    public TextMeshProUGUI textComponent;
    public static event Action GameStarted;

    private bool gameRuning = false;

    private void Update()
    {
        if (gameRuning)
        {
            if (Time.timeScale > 0.01f)
            {
                Time.timeScale = Mathf.Clamp(Time.timeScale + 0.00015f, 1.0f, 10.0f);
                Debug.Log(Time.timeScale);
            }

            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameRuning = true;
            Cursor.visible = false;
            star.SetActive(false);
            textComponent.enabled = false;
            GameStarted?.Invoke();
            playerAnimator.enabled = true;
            DOTween.Kill("pulseFade");
        }
    }
}