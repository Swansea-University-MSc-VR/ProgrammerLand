using System.Collections;
using UnityEngine;

public class PirateShip : MonoBehaviour
{
    public bool pirateShipEnabled = false;
    public float speed = 1.0f;
    public Vector3 leftRotation;
    public Vector3 rightRotation;
    private bool rotatingLeft = true;
    public float angleThreshold = 10f;
    private float timer;
    public float lerpTime;

    void Update()
    {
        if (!pirateShipEnabled)
            return;

        if (rotatingLeft)
        {
            // The longer you set the duration, the smaller the increments.
            timer += Time.deltaTime / lerpTime;
            // Compute a blend weight that eases in at the start and out at the end.
            float blend = Mathf.SmoothStep(0, 1, timer);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(leftRotation), blend);

            if (Quaternion.Angle(transform.rotation, Quaternion.Euler(leftRotation)) < angleThreshold)
            {
                rotatingLeft = false;
                timer = 0f;

                //increase the rotation here
                float rotationAmount = leftRotation.x + 10;

                leftRotation = new Vector3(rotationAmount, leftRotation.y, leftRotation.z);
            }
        }
        else
        {
            // The longer you set the duration, the smaller the increments.
            timer += Time.deltaTime / lerpTime;

            // Compute a blend weight that eases in at the start and out at the end.
            float blend = Mathf.SmoothStep(0, 1, timer);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rightRotation), blend);

            if (Quaternion.Angle(transform.rotation, Quaternion.Euler(rightRotation)) < angleThreshold)
            {
                rotatingLeft = true;
                timer = 0f;

                //increase the rotation here
                float rotationAmount = rightRotation.x - 10;

                rightRotation = new Vector3(rotationAmount, rightRotation.y, rightRotation.z);
            }
        }
    }
}
