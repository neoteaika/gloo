using System.Collections; using System.Collections.Generic; using UnityEngine;
/*        AUDIO CORE
Aim is to use this to store all of the various stored sounds as a sort of "global library" for audio.
We want to pull from this class to define whatever sounds are available for other classes/methods(?) to use.*/
public class AudioCore : MonoBehaviour //  Older sound manager, wasnt' really sure what i was doing yet so need to come to this
{
    public float volSFX = 1.0f;
    public AudioSource audioSource;
    public AudioClip    //  Globals for all the various sounds we'll want to use.
    sfxTest0, sfxTest1, //  Test/placeholder sounds
    sfxObjExplosion, sfxBombBounce, //  Weapons & explosions
    sfxUIAccept, sfxUIBack, sfxUISelect, sfxUISwipe,    //  UI stuff
    sfxEnemyAlert, sfxEnemyHurt, sfxEnemyDeath, //  Enemy sounds
    sfxHoloDismiss, sfxHoloAct, sfxVendoAmb, sfxVendoAct,   //  Holofrog/Vendo
    sfxLvlPadSpawn, sfxLvlPadCheck, sfxLvlPad0, sfxLvlPad1, //  LevelSFX
    sfxLvlSwitch0, sfxLvlSwitch1, sfxDoor0, sfxDoor1,   //  LevelSFX
    sfxAmbSpace, sfxAmbComputers, sfxAmbMars;   //  LevelSFX
}