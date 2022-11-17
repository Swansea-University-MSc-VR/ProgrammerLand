using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Guest : MonoBehaviour
{
    public string guestFirstName;
    public string guestSecondName;
    public float cash;
    public Ride targetRide; // ride the guest is currently trying to go on
    public bool isQueueing;

    public Rubbish rubbishPrefab;

    private NavMeshAgent _navMeshAgent;

    private float _rubbishTime; // how long to wait untill guest drops rubbish
    private float _rubbishTimer; // a timer that keeps track when the guest should drop gue

   

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.SetDestination(RandomNavmeshLocation(100f));

        _rubbishTime = Random.Range(3f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if(_navMeshAgent.hasPath)
        {
            if(_navMeshAgent.remainingDistance < 0.5f && !_navMeshAgent.isStopped)
            {
                StartCoroutine(StopAndWait());
            }
        }

        if (_rubbishTimer < _rubbishTime)
        {
            _rubbishTimer += Time.deltaTime;
        }
        else
        {
            Instantiate(rubbishPrefab, transform.position, Quaternion.identity);
            _rubbishTimer = 0;
            _rubbishTime = Random.Range(3f, 10f);
        }
    }

    private IEnumerator StopAndWait()
    {
        _navMeshAgent.isStopped = true;

        float waitTime = Random.Range(1f, 5f);
        yield return new WaitForSeconds(waitTime);

        _navMeshAgent.SetDestination(RandomNavmeshLocation(100f));

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