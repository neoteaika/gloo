using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : Death
{
    public Vector3 spawnLocation;
    public Quaternion spawnRotation;
    public GameCore gameCore;
    void Start()
    {
        spawnLocation = transform.position;
        spawnRotation = transform.rotation;

        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    public override void HandleDeath()
    {
        gameCore.DecreasePlayerLives();

        Debug.Log("DEAD");
        GetComponent<Rigidbody>().position = spawnLocation;
        GetComponent<Rigidbody>().rotation = spawnRotation;

        if(TryGetComponent<Health>(out Health health))
        {
            health.RecoverFull();
        }
    }
}