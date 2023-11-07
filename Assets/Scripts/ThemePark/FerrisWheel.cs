using UnityEngine;

public class FerrisWheel : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public int rotationCount = 3;
    private int currentRotation = 0;
    private float totalRotation = 0.0f;
    public float lineLength = 5.0f;
    
    void Update()
    {
        if (currentRotation < rotationCount)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
            totalRotation += Time.deltaTime * rotationSpeed;
            if (totalRotation >= 360.0f)
            {
                currentRotation++;
                totalRotation = 0.0f;

         
            }
        }

        Vector3 center = transform.position;
        Vector3 direction = transform.forward;
        Debug.DrawLine(center, center + direction * lineLength, Color.red);
    }

    //void Update()
    //{
    //    if (currentRotation < rotationCount)
    //    {
    //        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
    //        totalRotation += Time.deltaTime * rotationSpeed;
    //        if (totalRotation >= 360.0f)
    //        {
    //            currentRotation++;
    //            totalRotation = 0.0f;
    //        }
    //    }
    //}
}
