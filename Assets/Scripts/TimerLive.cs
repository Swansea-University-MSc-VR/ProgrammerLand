using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLive : MonoBehaviour
{
    private float timer = 0f;
    public float targetTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        timer = targetTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer >= 0)
        {
            timer -= Time.deltaTime;

            // debug log the timer to zero decimal places
            Debug.Log("Time remaining: " + timer.ToString("1"));

        }
        else
        {
            Debug.Log("Timer is done!");
        }
    }
}
