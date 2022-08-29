using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Woof());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Woof()
    {
        AudioSource dogAudioSource = GetComponent<AudioSource>();

        while (true)
        {
            dogAudioSource.pitch = Random.Range(0.8f, 1.1f);
            dogAudioSource.Play();
            yield return new WaitForSeconds(1f);
        }
    }
}
