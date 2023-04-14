using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variable
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get players input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Allow rotation
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}

// >> NOTES
// Translate(Vector3.forward) = Translate(0,0,1)
// Time.deltaTime allows to keep track of *seconds* instead of frames
// Use transform.Rotate instead of transform.Translate to avoid the object to slide
// Variables: private can be accessed only within the class ≠ public
// When a variable has value assigned is said "initialized"
// Remember that difference in Game Scene between Global (axes referenced to the world)
//      and Local (axes referenced to the obj) POV