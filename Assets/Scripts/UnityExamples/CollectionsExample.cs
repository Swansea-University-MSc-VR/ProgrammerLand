using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsExample : MonoBehaviour
{
    public GameObject[] yellowMen;
    public GameObject[] redMen;

    public Transform puppySpawnPoint;
    public Puppy puppyPrefab;

    public List<Puppy> puppies;
  

    // Start is called before the first frame update
    void Start()
    {
       // ArrayExample();

        ListExample();
    }

    private void ArrayExample()
    {
        redMen = new GameObject[5];

        //find redMen object
        GameObject redMenParent = GameObject.Find("Red Men");

        for (int i = 0; i < redMen.Length; i++)
        {
            redMen[i] = redMenParent.transform.GetChild(i).gameObject;
        }            
    }

    private void ListExample()
    {
       // StartCoroutine(CreatePuppies());

       StartCoroutine(RandomiseTheMen());
    }

    private IEnumerator CreatePuppies()
    {
        while (true)
        {
            Puppy pup = Instantiate(puppyPrefab, puppySpawnPoint.position, puppySpawnPoint.rotation, null);

            pup.GetComponent<Walk>().speed = 1f;

            puppies.Add(pup);

            yield return new WaitForSeconds(1f);
        }

    }

    private IEnumerator RandomiseTheMen()
    {
        // create list of men
        List<Man> allMenList = new List<Man>();

        //create array of men
        GameObject[] allMenArray = GameObject.FindGameObjectsWithTag("Man");

        // fill the list with the array of men
        for (int i = 0; i < allMenArray.Length; i++)
        {
            allMenList.Add(allMenArray[i].GetComponent<Man>());
        }

        while(true)
        {
            int random = UnityEngine.Random.Range(0, allMenList.Count);
             
            float randomScale = UnityEngine.Random.Range(0.5f, 2.5f);

            allMenList[random].transform.localScale = new Vector3(randomScale, randomScale, randomScale);

            yield return new WaitForSeconds(1f);
        }
    }
}
