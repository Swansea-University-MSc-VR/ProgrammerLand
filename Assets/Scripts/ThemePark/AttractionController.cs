using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractionController : MonoBehaviour
{
    public Attraction[] attractions;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
       // attractions = new Attraction[3];
        ShutDownAttractions();
    }

    // Update is called once per frame
    void ShutDownAttractions()
    {

        //for (int i = 0; i < attractions.Length; i++)
        //{
        //    Debug.Log(i);
        //    attractions[i].IsOperational = false;
        //}
           




        //    for (int i = 0; i < attractions.Length; i++)
        //    {
        //        attractions[i].IsOperational = false;
        //    }

        //    foreach (var attraction in attractions)
        //    {
        //        attraction.IsOperational = false;
        //    }

        //int i = 0;
        //while (i < attractions.Length)
        //{
        //    attractions[i].IsOperational = false;
        //    i++;
        //}
    }

}
