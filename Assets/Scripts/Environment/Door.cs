using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 closePosition, openPosition; // Positions
    public float duration = 1.2f, closeDelay = 0.8f;    // Timing
    public enum DoorState
    {
        Closed, Open, IsOpening, IsClosing
    };
    public DoorState doorState = DoorState.Closed;
    void Start()
    {
        closePosition = transform.position;
    }
    private void OnCollisionEnter(Collision other)
    {
        switch (doorState)
        {
            case DoorState.Closed:
                StartCoroutine("OpenDoor");
                break;
            case DoorState.Open:
                StartCoroutine("ShutDoor");
                break;
        }
    }
    IEnumerator OpenDoor()
    {
        doorState = DoorState.IsOpening;
        float timeElapsed = 0f;
        while (timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(closePosition, openPosition,
            timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        // once we're done with the loop, we force the final position just in case
        transform.position = openPosition;
        // Set the state
        doorState = DoorState.Open;
        // Close the door after a delay
        StartCoroutine("ShutDoorAfterDelay");
    }
    IEnumerator ShutDoor()
    {
        doorState = DoorState.IsClosing;
        float timeElapsed = 0f;
        while (timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(openPosition, closePosition,
            timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = closePosition;
        doorState = DoorState.Closed;
    }
    IEnumerator ShutDoorAfterDelay()
    {
        yield return new WaitForSeconds(closeDelay);
        if (doorState == DoorState.Open)
        {
            StartCoroutine("ShutDoor");
        }
    }
}