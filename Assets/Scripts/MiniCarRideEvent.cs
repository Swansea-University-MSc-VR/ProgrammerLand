using UnityEngine;
using UnityEngine.Events;

public class MiniCarRideEvent : MonoBehaviour
{
    // Unity Event to be invoked when a player enters the trigger zone
    public UnityEvent onPlayerEnter;

    public delegate void PhotoTakenHandler();
    public static event PhotoTakenHandler OnPhotoTaken;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            // Check if the entering collider is tagged as "Car"
            // If yes, invoke the Unity Event
            onPlayerEnter.Invoke();
            Debug.Log("Car entered the trigger zone");


            // Invoke the PhotoTaken event
            OnPhotoTaken?.Invoke();
        }
    }
}
