using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    float timeLeft;
    Color targetColor;

    void Start()
    {
    }
    
    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color
            Renderer.material.color = targetColor;

            // start a new transition
            targetColor = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color
            Renderer.material.color = Color.Lerp(Renderer.material.color, targetColor, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }

        // transform.localScale = Vector3.one * Time.deltaTime;

        transform.localScale = new Vector3(Mathf.PingPong(Time.time, 3), Mathf.PingPong(Time.time, 6), Mathf.PingPong(Time.time, 9));


    }
}
