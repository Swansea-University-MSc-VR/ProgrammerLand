using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    float temperature = 20.7f;

    bool willItRainToday;

    string currentLocation = "swansea";

    // Start is called before the first frame update
    void Start()
    {
        willItRainToday = true;
        currentLocation = "new york";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
