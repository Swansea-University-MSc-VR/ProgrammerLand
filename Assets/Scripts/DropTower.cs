using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTower : MonoBehaviour
{
    public float dropTime;
    public float goUpTime;
    public float cooldownTime;

    private float timer;

    public float goUpSpeed;
    public float dropSpeed;

    public enum DropTowerState 
    {        
        Dropping,
        GoingUp,
        Cooldown 
    }
    public DropTowerState currentState;

    // Start is called before the first frame update
    void Start()
    {
        StartRide();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case DropTowerState.Dropping:
                Drop();
                break;
            case DropTowerState.GoingUp:
                GoUp();
                break;
            case DropTowerState.Cooldown:
                Cooldown();
                break;
            default:
                break;
        }
    }

    private void StartRide()
    {
        timer = goUpTime;
        currentState = DropTowerState.GoingUp;
    }

    private void GoUp()
    {
        if(timer > 0f)
        {
            timer -= Time.deltaTime;
            transform.transform.Translate(Vector3.up * goUpSpeed * Time.deltaTime);
        }
        else
        {
            currentState = DropTowerState.Dropping;
            timer = dropTime;
        }
    }

    private void Drop()
    {
        if(timer > 0f)
        {
            timer -= Time.deltaTime;
            transform.Translate(Vector3.down * dropSpeed * Time.deltaTime);
        }
        else
        {
            currentState = DropTowerState.Cooldown;
            timer = cooldownTime;
        }
    }

    private void Cooldown()
    {
        if(timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            StartRide();
        }
    }

}
