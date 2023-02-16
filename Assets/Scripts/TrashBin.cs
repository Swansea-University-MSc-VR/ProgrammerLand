using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public float throwForce = 10.0f;
    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is a rigidbody
        if (other.GetComponent<Rigidbody>() != null)
        {
            // Calculate the direction to throw the rigidbody
            Vector3 throwDirection = (other.transform.position - transform.position).normalized;

            // Apply force to the rigidbody to throw it in the calculated direction
            other.GetComponent<Rigidbody>().AddForce(throwDirection * throwForce, ForceMode.Impulse);

            // Debugging line to demonstrate breakpoint usage
            Debug.Log("Threw object in direction: " + throwDirection);
        }
    }
}
