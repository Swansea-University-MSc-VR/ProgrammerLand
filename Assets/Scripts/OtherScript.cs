using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherScript : MonoBehaviour
{
    public ExampleScrip exampleScrip;
    public ExampleScrip exampleScrip2;

    // Start is called before the first frame update
    void Start()
    {
        exampleScrip.myInt = 10;          
        exampleScrip2.myInt = 20;
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
