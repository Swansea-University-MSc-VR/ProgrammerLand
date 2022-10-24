using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public GameObject sign;

    public int number;
  

    // Start is called before the first frame update
    void Start()
    {
        sign.GetComponent<TextMeshPro>().text = "ProgrammerLand";
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
