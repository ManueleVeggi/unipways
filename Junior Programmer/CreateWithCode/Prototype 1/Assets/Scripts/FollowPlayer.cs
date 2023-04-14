using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera secondCamera;
    private Vector3 offset = new Vector3(-5, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // The camera now follows the player
        transform.position = player.transform.position + offset;

        secondCamera.transform.position = player.transform.position + new Vector3(0.5f,2,0.8f);
    }
}
