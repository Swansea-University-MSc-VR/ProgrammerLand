using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Man : MonoBehaviour
{
    private string manName = "Bob";
    private readonly int age = 27;

    public Dog dog;
    public bool introduceSelf;

    void Start()
    {
        RenameDog("Rusty");

        if(introduceSelf)
        {
            string introduceMyself = "Hello, I'm " + age + ", my name is " + manName + " and my dog is called " + dog.dogName;
            Debug.Log(introduceMyself);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        // check if the C key has been pressed. This key will clear the grid and pause the game
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            MorningRoutine();
        }
    }

    private void RenameDog(string newDogName)
    {
        if (dog != null)
        {
            dog.dogName = newDogName;
        }
        else
            Debug.LogWarning("no dog");
    }

    private void MorningRoutine()
    {
        // Eat
        TakeDogForWalk();
        // Go To Work
    }

    private void TakeDogForWalk()
    {

        // call dogs name 
        if (dog != null)
        {
            Debug.Log("Hey " + dog.dogName);
            dog.CallDogsName();
        }
        
        //TODO
        // Attach Lead
        // Walk       

    }
}
