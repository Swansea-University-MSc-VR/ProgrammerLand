using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherScript : MonoBehaviour
{
    public ExampleScript exampleScript1;
    public ExampleScript exampleScript2;

    // Start is called before the first frame update
    void Start()
    {
        exampleScript1.number = 10;
        exampleScript2.number = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
