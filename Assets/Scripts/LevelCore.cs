using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCore : MonoBehaviour
{
    public GameObject gameCore;
    public GameObject gameHUD;
    public Canvas gameCanvas;

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    void Start()
    {
        gameCanvas = gameHUD.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
