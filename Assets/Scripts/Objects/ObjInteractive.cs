using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInteractive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            Debug.Log("Interactive");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            Debug.Log("NOT Interactive");
        }
    }
}
