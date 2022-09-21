using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float waitingCounter=0;
    public float pressInterval = 10f;
    public float nextAllowedPressTime = 0f;
    public float startTime = 0;

    // Update is called once per frame
    void Update()
    {
        startTime = Time.time;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && startTime > nextAllowedPressTime)
        {

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextAllowedPressTime = startTime + 1.5f;
            Debug.Log("You pressed at time : "+startTime);
            Debug.Log("You could press again at time : " + nextAllowedPressTime);
        }
    }
}
