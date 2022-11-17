using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An Attraction could be a rollercoaster or something smaller like the ball toss game
/// </summary>
public class Attraction : MonoBehaviour
{
    public bool IsOperational { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        IsOperational = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
