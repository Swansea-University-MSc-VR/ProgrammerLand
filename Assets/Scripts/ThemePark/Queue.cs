using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    public Guest guest;

    public List<Guest> guests = new List<Guest>();

    // Start is called before the first frame update
    private void Start()
    {
      //  Debug.Log("This script keeps track of the number of guests in a queue for a ride");

        AddGuestToQueue(guest);

        RemoveGuestFromQueue(guest);
    }

    private void AddGuestToQueue(Guest guest)
    {
      //  Debug.Break();
        guests.Add(guest);
    }

    private void RemoveGuestFromQueue(Guest guest)
    {
        if (guest != null)
        {
            guest.RandomNavmeshLocation(5f);

            guests.Remove(guest);
        }
        else
        {
            
            Debug.LogWarning("you tried to remove a guest that is null");
        }
    }
}

