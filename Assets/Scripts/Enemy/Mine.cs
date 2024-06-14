using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mine : MonoBehaviour
{
    public EnemyRadar radar;
    public float translateSpeed = 10f;
    public bool useNavMesh;
    void Update()
    {
        if(radar.isActive)
        {
            if (useNavMesh)
            {
                var agent = GetComponent<NavMeshAgent>();
                agent.destination = radar.player.transform.position;
            }
            else
            {
                transform.Translate(Vector3.forward * Time.deltaTime * translateSpeed);
            }
        }
    }
}
