using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes = 0;
    public int seconds = 0;
    public int milliseconds = 0;
    public bool isRunning = false;
    public bool isPaused = false;

    public GameObject pointerMinutes;
    public GameObject pointerSeconds;
    public GameObject pointerMilliSeconds;

    void Start()
    {
        
    }

    void Update()
    {
        if(isRunning)
        {
            
            StartCoroutine("TimeStart");
            
        }
    }
    public void StartTimer()
    {
        if(!isPaused)
        {
            isRunning = true;
            isPaused = true;    
        }
        else
        {
            isRunning = false;
            StopCoroutine("TimeStart");
            isPaused = false;
        }

    }

    public void ResetTimer()
    {
        StopCoroutine("TimeStart");
        minutes = 0;
        seconds = 0;
        milliseconds = 0;
    }


    IEnumerator TimeStart()
    {
        milliseconds += 1;
        if(milliseconds >= 100)
        {
            milliseconds = 0;
            seconds += 1;
        }
        if(seconds >= 60)
        {
            seconds = 0;
            minutes += 1;
        }
            float rotationSeconds = (360.0f / 60.0f) * -seconds;
            float rotationMinutes = (360.0f / 60.0f) * -minutes;
            float rotationMilliSeconds = (360.0f / 100.0f) * -milliseconds;

            pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
            pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
            pointerMilliSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMilliSeconds);

        yield return new WaitForSeconds(1); 
    }
}
