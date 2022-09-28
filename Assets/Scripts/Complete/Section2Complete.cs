using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Section2Complete : MonoBehaviour
{
    //variables to store customer data
    public string customerName;
    public string customerAddress;
    public int cusomterPhonenumber;
    public string customerEmail;

    public float ticketPrice;
    public int ticketQuantity;
    public float totalCost;

    public bool loyaltyCardMember;
    public bool concession;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(customerName);

        //calculate total cost
        totalCost = ticketPrice * ticketQuantity;

        // print out total cost
        Debug.Log(totalCost);
    }
}