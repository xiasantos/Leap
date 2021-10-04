using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopingbackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;


    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(0f, - backgroundSpeed * Time.deltaTime);
    }
}
