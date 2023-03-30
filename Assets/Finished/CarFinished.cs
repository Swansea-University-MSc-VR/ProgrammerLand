using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarFinished : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float power;
    public float speed;

    public GameObject fireSteaks;
    public Transform fireStreakSpawnLocation;

    public Transform timeTravelTarget;


    private bool _hasTimeTravelled;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * power);       

        CheckSpeed();
    }

    private void CheckSpeed()
    {
        speed = _rigidbody.velocity.magnitude;

        // convert speed to mph  - multiply the speed value by 2.237
        speed = speed * 2.237f;

        if(speed > 88f && _hasTimeTravelled == false)
        {
            TimeTravel();
        }

        ConversionHelper.ConvertToMPH(speed);

    }

    private void TimeTravel()
    {
        Instantiate(fireSteaks, fireStreakSpawnLocation.position, fireStreakSpawnLocation.rotation, null);

        transform.position = timeTravelTarget.position;
        _hasTimeTravelled = true;
    }


}
