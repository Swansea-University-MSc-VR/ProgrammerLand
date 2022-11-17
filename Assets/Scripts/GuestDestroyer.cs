using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestDestroyer : MonoBehaviour
{
    public Guest guestToBeDestroyed;

    private GuestController _guestController;

    // Start is called before the first frame update
    void Start()
    {
        _guestController = GetComponent<GuestController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button]
    public void DestroyGuest()
    {
        if(_guestController.guests.Contains(guestToBeDestroyed))
        {
            _guestController.guests.Remove(guestToBeDestroyed);
            Destroy(guestToBeDestroyed);
        }    
    }
}
