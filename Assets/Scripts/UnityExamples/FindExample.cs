using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindExample : MonoBehaviour
{
    public GameObject man;

    public GameObject dog;

    public Puppy puppy;

    public GameObject puppyTail;

    public GameObject puppyChewToy;

    public GameObject puppyHead;

    // Start is called before the first frame update
    void Start()
    {
        // find the man
        man = GameObject.Find("Steve");

        // find the dog using a tag
        dog = GameObject.FindGameObjectWithTag("Dog");

        // find the puppy by type
        puppy = GameObject.FindObjectOfType<Puppy>();

        // find the puppy's tail by using find from the transform class
        puppyTail = puppy.transform.Find("Tail").gameObject;

        // find the chew toy
        puppyChewToy = puppy.transform.Find("Head/ChewToy").gameObject;

        // find the puppy's head by getChild
        puppyHead = puppy.transform.GetChild(2).gameObject;
    }
    
}
