using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public GameObject sign;
    // Start is called before the first frame update
    void Start()
    {
        sign.GetComponent<TextMeshPro>().text = "some new text";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
