using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player;
    public float smoothing = 0.2f;
    public bool followEnabled = true;

    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;  
        offset = transform.position - player.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (followEnabled)
        {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothing);
        transform.LookAt(player);
        }
    }
}
