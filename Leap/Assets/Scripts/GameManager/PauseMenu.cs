using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public AudioSource frogSound;

    private float storedTimeScale = 1.0f;

    private void Update()
    {
        if (Input.GetKeyDown("p")||Input.GetKeyDown("escape"))
        {
            Pause();
        }
    }

    public void Pause()
    {
        storedTimeScale = Time.timeScale;
        Time.timeScale = 0.0f;
        frogSound.Play();
        pauseMenuUI.SetActive(true);
        Cursor.visible = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = storedTimeScale;
    }
}
