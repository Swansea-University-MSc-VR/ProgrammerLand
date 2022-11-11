using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestDestroyer : MonoBehaviour
{
    public Guest guestToBeDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button]
    public void DestroyGuest()
    {

       Destroy(guestToBeDestroyed);
    }
}
