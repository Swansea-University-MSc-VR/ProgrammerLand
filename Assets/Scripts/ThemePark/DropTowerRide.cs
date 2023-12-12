using UnityEngine;

public class DropTowerRide : MonoBehaviour
{
    public float ascentDuration = 10f;      // Duration of the ascent in seconds
    public float dropDuration = 3f;         // Duration of the drop in seconds
    public float cooldownDuration = 5f;    // Cooldown time before the ride can start again

    private enum RideState { Idle, Ascending, Dropping, Cooldown }
    private RideState currentState = RideState.Idle;

    private float timer;

    public float ascentSpeed = 1f;
    public float dropSpeed = 5f;

    void Start()
    {
        StartRide();
    }

    void Update()
    {
        switch (currentState)
        {
            case RideState.Ascending:
                UpdateAscent();
                break;

            case RideState.Dropping:
                UpdateDrop();
                break;

            case RideState.Cooldown:
                UpdateCooldown();
                break;
        }
    }

    void StartRide()
    {
        currentState = RideState.Ascending;
        timer = ascentDuration;
        Debug.Log("Ascent started!");
    }

    void UpdateAscent()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            transform.Translate(Vector3.up * ascentSpeed * Time.deltaTime);
        }
        else
        {
            currentState = RideState.Dropping;
            timer = dropDuration;
            Debug.Log("Ascent complete. Prepare for the drop!");
        }
    }

    void UpdateDrop()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            transform.Translate(Vector3.down * dropSpeed * Time.deltaTime);
        }
        else
        {
            currentState = RideState.Cooldown;
            timer = cooldownDuration;
            Debug.Log("Drop complete. Ride cooldown initiated.");
        }
    }

    void UpdateCooldown()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            currentState = RideState.Idle;
            StartRide(); // Restart the ride after the cooldown
        }
    }
}
