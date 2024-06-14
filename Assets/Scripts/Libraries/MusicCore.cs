using System.Collections; using System.Collections.Generic; using UnityEngine;
/*        MUSIC CORE
Same deal as the Audio Core, really. I just want to keep any music logic
separated for organization purposes + being handled differently*/
public class MusicCore : MonoBehaviour
{
    public float volMusic = 1.0f;
    public AudioSource audioPlayaMusic;
    public AudioClip musicMenu,   //  Globals for all the various sounds we'll want to use.
    music00, music01, music02,  //  Maybe a shuffled playlist?
    music03, music04, music05;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioPlayaMusic = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        audioPlayaMusic.Play();
    }

    public void StopMusic()
    {
        audioPlayaMusic.Stop();
    }
    
    public void PlayTrax()
    {
        audioPlayaMusic.clip = musicMenu;
        audioPlayaMusic.Play();
    }
}
