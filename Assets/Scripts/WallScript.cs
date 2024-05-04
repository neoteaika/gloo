using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("DENT");
        if(other.gameObject.TryGetComponent(out PlayerBullet bullet))
        {
            Destroy(bullet.gameObject);
            GetComponentInChildren<Renderer>().material.color = Color.red;
        }
    }
}
