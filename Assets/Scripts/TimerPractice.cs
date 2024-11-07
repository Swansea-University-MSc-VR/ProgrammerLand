using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPractice : MonoBehaviour
{
    private float timer = 0f;
    public float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeToWait;

    }

    // Update is called once per frame
    void Update()
    {
        //if(timer < timeToWait)
        //{
        //    timer += Time.deltaTime;
        //}
        //else
        //{
        //    Debug.Log("Timer is done!");
        //}

       

       // countdown until timer is done 
       if(timer > 0f)
        {
            timer -= Time.deltaTime;

            // debug log time remaining to zero decimal places
            Debug.Log("Time remaining: " + timer.ToString("0"));

        }
        else
        {
            Debug.Log("Timer is done!");
        }

    }
}
