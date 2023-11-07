using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ballRigidbody;
    private Vector3 startingPosition;

    public GameObject[] pins;
    public List<Vector3> pinStartingPositions;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        startingPosition = transform.position;

        pins = GameObject.FindGameObjectsWithTag("Pin");

        foreach (GameObject pin in pins)
        {
           pinStartingPositions.Add(pin.transform.localPosition);
        }
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

    [Button]
    private void ResetCubes()
    {
        for (int i = 0; i < pins.Length; i++)
        {           
            pins[i].transform.SetLocalPositionAndRotation(pinStartingPositions[i], Quaternion.identity);
        }
    }
}
