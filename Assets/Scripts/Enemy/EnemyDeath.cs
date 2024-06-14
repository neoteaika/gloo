using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : Death
{
    public GameObject fxExplosion;
    public GameCore gameCore;
    public int scoreValue = 10;

    IEnumerator EnemyExplosion()
    {
        Instantiate(fxExplosion, transform.position, transform.rotation);
        yield return null;
    }
    void Start()
    {
        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    public override void HandleDeath()
    {
        StartCoroutine(EnemyExplosion());
        gameCore.ScorePlus(scoreValue);
        Destroy(gameObject);
    }
}
