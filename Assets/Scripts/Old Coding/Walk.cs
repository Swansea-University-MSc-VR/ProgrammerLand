using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // use deltaTime to move things consistantly regardless of framerate

        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
