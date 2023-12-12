using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkControl : MonoBehaviour
{

    public bool isCafeOpen;
    public bool isAcceptingOrders;

    public int numberOfMuffinsOrdered;
    public int numberOfMuffinsInStock = 10;

    public string nextParkToVisit;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        GameManager.Instance.StartThemePark();

        yield return new WaitForSeconds(5f);

        //load next park to visit scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextParkToVisit);

    }


   
}
