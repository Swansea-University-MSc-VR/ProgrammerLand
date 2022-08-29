using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathExample : MonoBehaviour
{
    public Light pointLight;
    public Dog dog;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FastDog());
    }

    // Update is called once per frame
    void Update()
    {
        // smoothly increases the intensity of the light overtime
        // from the value of _light.intensity to 5f
        // at a 50% rate per second (Time.deltaTime)
        pointLight.intensity = Mathf.Lerp(pointLight.intensity, 5f, 0.5f * Time.deltaTime);
    }

    private IEnumerator FastDog()
    {
        Walk dogWalk = dog.GetComponent<Walk>();

        while(true)
        {
            dogWalk.speed += 0.1f;

            dogWalk.speed =  Mathf.Clamp(dogWalk.speed, 0.1f, 5f);

           yield return new WaitForSeconds(0.1f);
        }
    }
}
