using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTestScript : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        //Destroy(gameObject, lifespan);
    }

    void Update()
    {
        
    }
}
