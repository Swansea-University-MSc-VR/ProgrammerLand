using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExample : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.Play("WagTail");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
