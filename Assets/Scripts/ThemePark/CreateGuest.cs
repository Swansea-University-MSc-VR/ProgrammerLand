using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGuest : MonoBehaviour
{
    public Guest guestPrefab;
    public GameObject spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button]
    public void CreateNewGuest()
    {
        Guest newGuest = Instantiate(guestPrefab, spawnPosition.transform.position, Quaternion.identity);

        GetComponent<GuestController>().guests.Add(newGuest);
    }
}
