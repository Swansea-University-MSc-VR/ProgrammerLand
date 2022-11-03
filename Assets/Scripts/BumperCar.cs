using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperCar : MonoBehaviour
{
    private float currentSpeed;
    private float bumperCarSpeed;

    public int numberOfDrivers;
    private bool bumperCarEmpty;

    public Driver driver;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {          
      
    }

    // this method makes the bumper car go
    public void Accelerate(float acceleratePedalPercentage)
    {
        currentSpeed += bumperCarSpeed * acceleratePedalPercentage;
    }

    public void Brake(float brakePedalPercentage)
    {  
        currentSpeed -= bumperCarSpeed * brakePedalPercentage;
    }


    public int NumberOfDriversToday()
    {
        return numberOfDrivers;
    }

    public void SafetyBriefing()
    {
        if (driver == null)
        {
            return;
        }

        // code run driver through safety briefing

    }

    public void GetInBumperCar(Driver driverGettingIn)
    {
        driver = driverGettingIn;
    }

    public void GetOutBumperCar()
    {
        driver = null;
    }

    [Button]
    public void Crash()
    {
        Debug.Log("you have crashed");
    }

}
