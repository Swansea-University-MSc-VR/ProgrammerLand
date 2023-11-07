using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PASystem : MonoBehaviour
{
    public AudioSource audioSource;
    public float waitTime = 120f;

    void Update()
    {
        if (Time.time > waitTime)
        {
            audioSource.Play();
            waitTime = Time.time + 120f;
        }
    }
}