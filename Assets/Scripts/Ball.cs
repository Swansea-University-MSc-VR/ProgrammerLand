using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ballRigidbody;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button]
    private void ShootBall()
    {
        ballRigidbody.AddForce(transform.forward * 1000f);
    }

    [Button]
    private void ResetBall()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
       
        ball.transform.SetPositionAndRotation(startingPosition, Quaternion.identity);

        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;
    }
}
