using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string dogName = "Einstein";
    public int numberOfLegs;
    public bool isAGoodBoy;
    public Man owner;

    public void Sit()
    {
        // sit
    }

    private void ChaseTail(int numberOfTimes)
    {
       // rotate ?
    }

    public void CallDogsName()
    {
        GetExcited();
    }

    private void GetExcited()
    {
        ChaseTail(UnityEngine.Random.Range(1, 5));
        // bark
    }

}
