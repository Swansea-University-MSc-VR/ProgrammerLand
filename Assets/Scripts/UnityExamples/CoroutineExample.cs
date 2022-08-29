using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    public float waitTime;
    Walk _walk;

    // Start is called before the first frame update
    void Start()
    {
        _walk = GetComponent<Walk>();

        StartCoroutine(WaitToWalk());
    }

    private IEnumerator WaitToWalk()
    {
        yield return new WaitForSeconds(waitTime);

        _walk.enabled = true;

        StartCoroutine(StopAfter5Meters());      
    }

    IEnumerator StopAfter5Meters()
    {
        float distanceCovered = 0;
       Vector3 startingPosition = transform.position;

        while(distanceCovered < 5)
        {
            distanceCovered = Vector3.Distance(startingPosition, transform.position);
            Debug.Log("I have travelled " + distanceCovered + " meters");
            yield return null;
        }

        _walk.enabled = false;       
    }
}
