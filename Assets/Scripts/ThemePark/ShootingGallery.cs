using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGallery : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform[] targetPositions;
    public float popUpDuration = 1.5f;
    public float popDownDuration = 0.5f;
    public float timeBetweenTargets = 2f;

    void Start()
    {
        StartCoroutine(TargetPopUpSequence());
    }

    IEnumerator TargetPopUpSequence()
    {
        while (true)
        {
            foreach (Transform targetPosition in targetPositions)
            {
                GameObject target = Instantiate(targetPrefab, targetPosition.position, targetPosition.rotation);
                yield return StartCoroutine(PopUpTarget(target));
                yield return new WaitForSeconds(timeBetweenTargets);
                yield return StartCoroutine(PopDownTarget(target));
            }
        }
    }

    IEnumerator PopUpTarget(GameObject target)
    {
        float elapsedTime = 0f;
        while (elapsedTime < popUpDuration)
        {
            target.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, elapsedTime / popUpDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator PopDownTarget(GameObject target)
    {
        float elapsedTime = 0f;
        while (elapsedTime < popDownDuration)
        {
            target.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, elapsedTime / popDownDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Destroy(target);
    }
}
