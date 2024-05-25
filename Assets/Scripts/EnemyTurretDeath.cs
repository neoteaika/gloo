using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurretDeath : Death
{
    public GameCore gameCore;
    public int value = 10;

    void Start()
    {
        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    public override void HandleDeath()
    {
        gameCore.ScorePlus(10);
        Destroy(gameObject);
    }
}
