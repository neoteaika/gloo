using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpin : MonoBehaviour
{
    private AudioSource audioSource;
    public float spinTime = 0.8f;
    void Update()
    {
        transform.Rotate(0,spinTime,0 * Time.deltaTime, Space.Self);
    }
}
