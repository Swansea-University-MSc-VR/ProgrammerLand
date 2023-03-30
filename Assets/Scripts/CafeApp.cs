using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CafeApp : MonoBehaviour
{
    public bool _isCafeOpen;
    public bool _acceptingOrders;

    public int numberOfMuffinsOrdered;
    public int numberOfMuffinsInStock;


    // Start is called before the first frame update
    void Start()
    {
        numberOfMuffinsInStock = Random.Range(0, 1000);

        Debug.Log("we are testing " + numberOfMuffinsInStock + " in stock");

        switch (numberOfMuffinsInStock)
        {
            case 0:
                Debug.LogWarning("No muffins left, please order more");
                break;

            case 1:
            case 2:
            case 3:
                Debug.Log("running low, order soon");
                break;

            case > 10:
                Debug.Log("we have plenty, dont worry");
                break;

            default:
                Debug.Log("We have muffins in stock");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
