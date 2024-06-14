using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectibleDisk : MonoBehaviour
{
    public GameObject fxCollection;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.layer == 8)
        {
            //playerDisks += 1;
            Instantiate(fxCollection, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
