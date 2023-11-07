using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestFinder : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        Guest guest;

        // find the guest
        guest = GameObject.Find("Guest").GetComponent<Guest>();
        Debug.Log(guest);

        // find the guest using a tag
        guest = GameObject.FindGameObjectWithTag("Guest").GetComponent<Guest>();
        Debug.Log(guest);

        // find the guest by type
        guest = GameObject.FindObjectOfType<Guest>();
        Debug.Log(guest);

        // find the guest's face by using find from the transform class
        GameObject face = guest.transform.Find("Face").gameObject;
        Debug.Log(face);

        // find the guest toy
        GameObject nose = guest.transform.Find("Face/Nose").gameObject;
        Debug.Log(nose);

        // find the guest's mouth  by getChild
        GameObject mouth = guest.transform.transform.Find("Face").GetChild(3).gameObject;
        Debug.Log(mouth);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
