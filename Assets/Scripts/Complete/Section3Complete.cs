using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Section3Complete : MonoBehaviour
{
    public GameObject sign;
    // Start is called before the first frame update
    void Start()
    {
        sign.GetComponent<TextMeshPro>().text = "ProgrammerLand";
    }
}
