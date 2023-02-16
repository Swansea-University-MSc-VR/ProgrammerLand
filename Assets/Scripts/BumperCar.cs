using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BumperCar : MonoBehaviour
{
    private float currentSpeed;
    private float bumperCarSpeed;

    public int numberOfDrivers;
    private bool bumperCarEmpty;

    public Driver driver;

    private NavMeshAgent _navMeshAgent;


    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.SetDestination(RandomNavmeshLocation(5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (_navMeshAgent.hasPath)
        {
            if (_navMeshAgent.remainingDistance < 0.5f && !_navMeshAgent.isStopped)
            {
                StartCoroutine(StopAndWait());
            }
        }
    }

    // this method makes the bumper car go
    public void Accelerate(float acceleratePedalPercentage)
    {
        currentSpeed += bumperCarSpeed * acceleratePedalPercentage;
    }

    public void Brake(float brakePedalPercentage)
    {  
        currentSpeed -= bumperCarSpeed * brakePedalPercentage;
    }


    public int NumberOfDriversToday()
    {
        return numberOfDrivers;
    }

    public void SafetyBriefing()
    {
        if (driver == null)
        {
            return;
        }
        // code run driver through safety briefing
    }

    public void GetInBumperCar(Driver driverGettingIn)
    {
        driver = driverGettingIn;
    }

    public void GetOutBumperCar()
    {
        driver = null;
    }

    [Button]
    public void Crash()
    {
        Debug.Log("you have crashed");
    }

    private IEnumerator StopAndWait()
    {
        _navMeshAgent.isStopped = true;

        float waitTime = Random.Range(0.2f, 1f);
        yield return new WaitForSeconds(waitTime);

        _navMeshAgent.SetDestination(RandomNavmeshLocation(5f));

        _navMeshAgent.isStopped = false;
    }

    public Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }



}
