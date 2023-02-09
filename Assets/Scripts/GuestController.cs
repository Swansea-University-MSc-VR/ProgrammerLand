using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestController : MonoBehaviour
{
    public List<Guest> guests;

    public Guest[] guestsByType;
    public List<Guest> guestsByTag = new List<Guest>();

    [Button]
    public void FindGuestsByType()
    {
        guestsByType = FindObjectsOfType<Guest>();        
    }


    [Button]
    public void FindGuestsByTag()
    {
        GameObject[] guestsWithTag = GameObject.FindGameObjectsWithTag("Guest");

        foreach (GameObject gameObject in guestsWithTag)
        {
            guestsByTag.Add(gameObject.GetComponent<Guest>()); 
        }
    }
}
