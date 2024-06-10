using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;
using UnityEngine.UI;
public class GameCore : MonoBehaviour
{
    //Manager script for game state shiz.
    public int playerLives = 3; //  Does the player have skill issues?
    public int playerScore = 0; //  Non-Disk score!
    public int playerDisks = 0; //  How many FLOPPY DISKS has the player collected?
    public int playerSecrets = 0; //    How many SECRET TAPES has the player collected?
    public int playerCards = 0; //  How many PLAYING CARDS has the player collected?
    public int playerBombs = 0; //  How many BOMBS does the player have?
    public float totalLevelSeconds = 20f;
    public float currentLevelSeconds;
    //public TextMeshProUGUI TextScore;
    //public TextMeshProUGUI TextTimer;

    public int playerProgression = 0;  //  What is the FURTHEST level the player has reached? (Maybe unlock levels in the menu)

    public void DecreasePlayerLives()
    {
        playerLives--;
        if(playerLives <= 0)
        {
            Debug.Log("SEGA RALLY GAME OVEER YEAAHA!");
        }
    }
    void Start()
    {
        currentLevelSeconds = totalLevelSeconds;
    }
    public void ScorePlus(int value)
    {
        playerScore += value;
        Debug.Log(playerScore);
    }

    void Update()
    {
        currentLevelSeconds -= Time.deltaTime;
        if(currentLevelSeconds <= 0f)
        {
            Debug.Log("Time out!");
        }
        //TextScore.text = playerScore.ToString();
    }
}
