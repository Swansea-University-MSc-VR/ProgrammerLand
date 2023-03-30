using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkControl : MonoBehaviour
{
    public bool isParkOpen;

    // Start is called before the first frame update
    void Start()
    {
        if (isParkOpen)
        { 
            Debug.Log("let the guests in");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
