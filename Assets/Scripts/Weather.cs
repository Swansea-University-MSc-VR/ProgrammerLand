using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Weather : MonoBehaviour
{
    float temperature = 24.5f;

    bool willItRainToday;

    string currentLocation = "Swansea";


    int number;

    int a = 4;
    int b = 10;


    // Start is called before the first frame update
    void Start()
    {
        //willItRainToday = true;
        //currentLocation = "New York";

        Debug.Log(currentLocation);
        Debug.Log(temperature);
        number = a * b;
        number = number / 2;
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
