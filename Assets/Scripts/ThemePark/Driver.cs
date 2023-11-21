using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public DodgeEm dodgeEm;
    public string name;
    public int skillLevel;

    public RollerCoaster rollerCoaster;

    private void Start()
    {
        Debug.Log(rollerCoaster.RideOperational);

        rollerCoaster.RideOperational = false;
    }

    [Button]
   public void GetInDodgEm()
    {
        dodgeEm.GetInDodgEm(this);
    }
}