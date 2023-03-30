using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammerLandComputer : MonoBehaviour
{
    public int numberOfGuests;

    public int MaxCapactiy;
    private bool windy;
    private bool rainy;

    // Start is called before the first frame update
    void Start()
    {
        numberOfGuests = Random.Range(0, 5000);

        if(numberOfGuests > MaxCapactiy)
        {
            Debug.Log("stop letting guests in the park");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
