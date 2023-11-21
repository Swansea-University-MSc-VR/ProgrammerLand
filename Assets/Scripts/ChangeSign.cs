using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeSign : MonoBehaviour
{
    public GameObject sign;

    public int peopleInTheClass = 15;

    public string dog = "Francis";

    // Start is called before the first frame update
    void Start()
    {
        sign.GetComponent<TextMeshPro>().text = dog + "20";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
