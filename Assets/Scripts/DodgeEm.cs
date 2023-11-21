using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeEm : MonoBehaviour
{

    public float bumperCarMaxSpeed;
    public float currentSpeed;
    public float pedalPercentage; // 0 to 1
    public int numberOfDrivers;

    public Driver driver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // pedal percentage = input from player thumbstick

        Accelerate(1f);
    }

    public void Accelerate(float pedalDownPercentage)
    {
        float accelerateAmount = pedalDownPercentage * 10;

        currentSpeed += bumperCarMaxSpeed * pedalDownPercentage;
    }

    public void Brake(float pedalDownPercentage)
    {
        

        currentSpeed -= bumperCarMaxSpeed * pedalDownPercentage;
    }

    public void EndRide()
    {
        numberOfDrivers++;
    }

    public int HowManyDriversToday()
    {
        return numberOfDrivers;
    }

    public void SafetyBriefing()
    {
        if (driver == null)
        {
            return;
        }
        else
        {
            Debug.Log("Welcome to the bumper cars, " + driver.name + "!");
        }

    }


    public void GetInDodgEm(Driver driverGettingIn)
    {
        driver = driverGettingIn;
        Debug.Log(driver.name + " is getting in the bumper car");   
    }

    public void GetOutBumperCar()
    {
        driver = null;

    }
}
