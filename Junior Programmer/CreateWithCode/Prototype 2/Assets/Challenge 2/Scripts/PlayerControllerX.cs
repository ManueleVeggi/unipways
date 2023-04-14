using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float gunHeat;
    private const float TimeBetweenShots = 0.25f;  // seconds

    // Update is called once per frame
    void Update()
    {
        // Here the timer goes on 
        if (gunHeat > 0)
        {
            gunHeat -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // only if time has passed!
            if (gunHeat <= 0)
            {
                // heat the gun up so we have to wait a bit before shooting again
                gunHeat = TimeBetweenShots;

                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            } else
            {
                Debug.Log("Hey! Wait!");
            }
        }
    }
}
