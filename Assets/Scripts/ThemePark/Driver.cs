using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public BumperCar bumperCar;


    private void Start()
    {
        bumperCar.Accelerate(100f);
    }
}