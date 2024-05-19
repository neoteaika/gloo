using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SentryMovement : MonoBehaviour
{
    public EnemyRadar radar;
    // Start is called before the first frame update
    void Start()
    {
        radar = GetComponent<EnemyRadar>();
    }

    // Update is called once per frame
    void Update()
    {
        if(radar.isActive)
        {
            transform.Translate(Vector3.forward);
        }
    }
}
