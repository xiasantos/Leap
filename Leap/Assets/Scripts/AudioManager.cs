using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource frogSound;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!frogSound.isPlaying)
            {
                frogSound.Play();
            }
        }
    }
}