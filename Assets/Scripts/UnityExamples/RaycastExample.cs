using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    public Transform raycastOrigin;

    public LayerMask layerMask;
    public GameObject hitSpawnObject;


    // Update is called once per frame
    void Update()
    {
       // SimpleRaycast();

        DetailedRaycast();
    }

    private void SimpleRaycast()
    {
        Debug.DrawRay(raycastOrigin.position, transform.forward * 1f, Color.magenta);

        if (Physics.Raycast(raycastOrigin.position, transform.forward, 1f))
        {            
            TurnAround();
        }
    }

    private void DetailedRaycast()
    {
        Debug.DrawRay(raycastOrigin.position, transform.forward * 1f, Color.magenta);

        RaycastHit hit;

        if (Physics.Raycast(raycastOrigin.position, transform.forward, out hit, 1f, layerMask))
        {
            Instantiate(hitSpawnObject, hit.point, Quaternion.LookRotation(transform.forward));
          
            TurnAround();
        }
    }

    private void TurnAround()
    {
        transform.rotation *= Quaternion.Euler(0, 180f, 0);
    }

   
}
