using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPlanter : MonoBehaviour
{
    public GameObject flower;

    public int numberOfFlowers;

    public List<Vector3> usedPositions = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {


        for (int i = 0; i < numberOfFlowers; i++)
        {
            Vector3 randomPosition = new Vector3(transform.position.x + Random.Range(-10, 10), 0, transform.position.z + Random.Range(-3, 3));
            Instantiate(flower, randomPosition, Quaternion.identity);

            usedPositions.Add(randomPosition);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
