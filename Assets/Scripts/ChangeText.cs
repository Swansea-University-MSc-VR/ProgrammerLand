using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public GameObject sign;
    public string hotdogType;
    public float price;
    // Start is called before the first frame update
    void Start()
    {
        hotdogType = "Bratwurst";
        price = 8.99f;

        sign.GetComponent<TextMeshPro>().text = hotdogType + price.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
