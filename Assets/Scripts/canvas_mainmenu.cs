using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas_mainmenu : MonoBehaviour
{
    public GameObject MenuMain;
    public GameObject MenuPlay;
    public GameObject MenuExit;
    public GameObject MenuSetup;
    // Start is called before the first frame update
    void Start()
    {
        ButtonMain();
    }

    public void ButtonLaunch()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TestProBuild");
        Debug.Log("LoadScene");
    }
    public void ButtonExitConfirm()
    {
        Application.Quit();
    }
    public void ButtonMain()
    {
        MenuMain.SetActive(true);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(false);
        MenuSetup.SetActive(false);
    }
    public void ButtonPlay()
    {
        MenuMain.SetActive(false);
        MenuPlay.SetActive(true);
        MenuExit.SetActive(false);
        MenuSetup.SetActive(false);
    }

    public void ButtonSetup()
    {
        MenuMain.SetActive(false);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(false);
        MenuSetup.SetActive(true);
    }

        public void ButtonExit()
    {
        MenuMain.SetActive(false);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(true);
        MenuSetup.SetActive(false);
    }
}
