using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameCore : MonoBehaviour
{
    //Manager script for game state shiz.
    public string sceneChange = "Died";    //  i  hate this
    public int pLives = 4, pScore = 0, pDisks = 0, pSecrets = 0, pCards = 0, pBombs = 0; //  Does the player have skill issues?
    public float totalLevelSeconds = 20f, currentLevelSeconds;
    public TextMeshProUGUI TextScore, TextTimer;
    public int playerProgression = 0;  //  What is the FURTHEST level the player has reached? (Maybe unlock levels in the menu)

    public void DecreasePlayerLives()
    {
        pLives--;
        if(pLives <= 1)
        {
            SceneManager.LoadScene(sceneChange);
        }
    }
    void Start()
    {
        currentLevelSeconds = totalLevelSeconds;
    }
    public void ScorePlus(int value)
    {
        pScore += value;
        Debug.Log(pScore);
    }

    void Update()
    {
        currentLevelSeconds -= Time.deltaTime;
        if(currentLevelSeconds <= 0f)
        {
            //Debug.Log("Time out!");
        }
        //TextScore.text = playerScore.ToString();
    }
}
