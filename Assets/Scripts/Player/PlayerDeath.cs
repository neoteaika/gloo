using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : Death
{
    public AudioClip deathSound;
    public AudioSource deathSource;
    public Vector3 spawnLocation;
    public Quaternion spawnRotation;
    public GameCore gameCore;
    public GameObject player;
    void Start()
    {
        spawnLocation = transform.position;
        spawnRotation = transform.rotation;

        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    IEnumerator Ascension()
    {
        Debug.Log("Respawning..." + Time.time);
        yield return new WaitForSeconds(0);
        Debug.Log("Subtracting one life..." + Time.time);
        gameCore.DecreasePlayerLives();
        deathSource.PlayOneShot(deathSound);
        GetComponent<Rigidbody>().position = spawnLocation;
        GetComponent<Rigidbody>().rotation = spawnRotation;

        if(TryGetComponent<Health>(out Health health))
        {
            health.RecoverFull();
        }
    }

    public override void HandleDeath()
    {
        Debug.Log("You died.");
        StartCoroutine(Ascension());
    }
}