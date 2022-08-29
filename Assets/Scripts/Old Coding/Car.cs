using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float power;
    public float speed;

    public Transform timeTravelPoint;
    private bool _hasTimeTravelled;

    public GameObject fireEffect;
    public Transform fireSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move the car
        _rigidbody.AddRelativeForce(Vector3.forward * power);

        // check speed
        CheckSpeed();
    }


    private void CheckSpeed()
    {
        speed = _rigidbody.velocity.magnitude;

        // convert speed to mph  - multiply the speed value by 2.237
        speed = speed * 2.237f;

        // check if car should time travel
        if(speed > 88f && _hasTimeTravelled == false)
        {
            TimeTravel();
        }

        // 
    }

    private void TimeTravel()
    {
        Instantiate(fireEffect, fireSpawnPoint.position, fireSpawnPoint.rotation, null);

        // travel through time
        transform.position = timeTravelPoint.position;

        _hasTimeTravelled = true;
    }
}
