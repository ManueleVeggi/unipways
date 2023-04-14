using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        secondCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("2"))
        {
            mainCamera.enabled = false;
            secondCamera.enabled = true;
        }

        if (Input.GetKey("3"))
        {
            mainCamera.enabled = true;
            secondCamera.enabled = false;
        }

    }
}
