using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPlanter : MonoBehaviour
{
    public GameObject flower;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomPosition = new Vector3(transform.position.x + Random.Range(-5, 5), 0, transform.position.z + Random.Range(-5, 5));
            Instantiate(flower, randomPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
