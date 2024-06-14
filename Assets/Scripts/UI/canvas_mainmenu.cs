using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas_mainmenu : MonoBehaviour
{
    //public AudioClip musicMenu;
    // Top Level Items
    public GameObject MenuMain, MenuPlay, MenuExit, MenuAbout; //  Spinning Gloo intro thingy, from here you can play, quit or view the credits.
    // Play Menu Items
    public GameObject MenuLevels, MenuCostumes, MenuMuseum, MenuSetup, MenuHelp;
    // Setup Menu Items
    //public GameObject AudioSFX, AudioMusic, DisplayFullscreen, GoBack_Setup;

    void Start()
    {
        //GameObject.FindGameObjectWithTag("AudioBrain").GetComponent<AudioCore>().audioSource.PlayOneShot(sfxTest0, volume);();
        ButtonMain();
    }
    public void ButtonLevels()
    {
        MenuHelp.SetActive(false); MenuLevels.SetActive(true);
        MenuMain.SetActive(false); MenuPlay.SetActive(false);
        MenuExit.SetActive(false); MenuAbout.SetActive(false);
    }
    public void ButtonLaunch()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
     public void ButtonHelp()
    {
        MenuHelp.SetActive(true); MenuLevels.SetActive(false);
        MenuMain.SetActive(false); MenuPlay.SetActive(false);
        MenuExit.SetActive(false); MenuAbout.SetActive(false);
    }
    public void ButtonExitConfirm()
    {
        Application.Quit();
    }
    public void ButtonMain()
    {
        MenuHelp.SetActive(false); MenuLevels.SetActive(false);
        MenuMain.SetActive(true); MenuPlay.SetActive(false);
        MenuExit.SetActive(false); MenuAbout.SetActive(false);
    }
    public void ButtonPlay()
    {
        MenuHelp.SetActive(false); MenuLevels.SetActive(false);
        MenuMain.SetActive(false); MenuPlay.SetActive(true);
        MenuExit.SetActive(false); MenuAbout.SetActive(false);
    }

    public void ButtonAbout()
    {
        MenuHelp.SetActive(false); MenuLevels.SetActive(false);
        MenuMain.SetActive(false); MenuPlay.SetActive(false);
        MenuExit.SetActive(false); MenuAbout.SetActive(true);
    }

        public void ButtonExit()
    {
        MenuHelp.SetActive(false); MenuLevels.SetActive(false);
        MenuMain.SetActive(false); MenuPlay.SetActive(false);
        MenuExit.SetActive(true); MenuAbout.SetActive(false);
    }
}
