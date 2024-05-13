using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas_mainmenu : MonoBehaviour
{
    // Top Level Items
    public GameObject MenuMain; //  Spinning Gloo intro thingy, from here you can play, quit or view the credits
    public GameObject MenuPlay;
    public GameObject MenuExit;
    public GameObject MenuAbout;

    // Play Menu Items
    public GameObject MenuLevels;
    public GameObject MenuCostumes;
    public GameObject MenuMuseum;
    public GameObject MenuSetup;
    public GameObject MenuHelp;

    // Setup Menu Items
    //public GameObject AudioSFX;
    //public GameObject AudioMusic;
    //public GameObject DisplayFullscreen;
    //public GameObject GoBack_Setup;

    void Start()
    {
        ButtonMain();
    }
    public void ButtonLevels()
    {
        MenuHelp.SetActive(false);
        MenuLevels.SetActive(true);

        MenuMain.SetActive(false);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(false);
        MenuAbout.SetActive(false);
    }
    public void ButtonLaunch()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TestProBuild");
        Debug.Log("LoadScene");
    }
     public void ButtonHelp()
    {
        MenuHelp.SetActive(true);
        MenuLevels.SetActive(false);

        MenuMain.SetActive(false);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(false);
        MenuAbout.SetActive(false);
    }
    public void ButtonExitConfirm()
    {
        Application.Quit();
    }
    public void ButtonMain()
    {
        MenuHelp.SetActive(false);
        MenuLevels.SetActive(false);

        MenuMain.SetActive(true);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(false);
        MenuAbout.SetActive(false);
    }
    public void ButtonPlay()
    {
        MenuHelp.SetActive(false);
        MenuLevels.SetActive(false);
        
        MenuMain.SetActive(false);
        MenuPlay.SetActive(true);
        MenuExit.SetActive(false);
        MenuAbout.SetActive(false);
    }

    public void ButtonAbout()
    {
        MenuHelp.SetActive(false);
        MenuLevels.SetActive(false);
        
        MenuMain.SetActive(false);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(false);
        MenuAbout.SetActive(true);
    }

        public void ButtonExit()
    {
        MenuHelp.SetActive(false);
        MenuLevels.SetActive(false);
        
        MenuMain.SetActive(false);
        MenuPlay.SetActive(false);
        MenuExit.SetActive(true);
        MenuAbout.SetActive(false);
    }
}
