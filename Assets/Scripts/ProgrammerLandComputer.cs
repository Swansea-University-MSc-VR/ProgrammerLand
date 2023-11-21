using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammerLandComputer : MonoBehaviour
{
    public DodgeEm dodgeEm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int totalDrivers = dodgeEm.HowManyDriversToday();
    }
}
