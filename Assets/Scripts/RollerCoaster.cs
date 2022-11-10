using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCoaster : MonoBehaviour
{
    private bool _rideOperational;
    public bool RideOperational
    {
        get
        {
            if(ExcessiveQueueLength() == true )
            {
                return false;
            }
            else
            {
                 return _rideOperational;
            }
        }
        set
        {
            _rideOperational = value;
        }
    }


    private bool SafetyChecksPassed()
    {
        return true;
    }

    private bool ExcessiveQueueLength()
    {
        return false;
    }

}
