using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public int wallGrade = 5, wallStrength = 3, wallStrengthInt = 3, matnum;
    //  At 0 Strength, reset to Int and lower Grade by 1.
    //  On creation or Grade changes, reset Strength to (x)
    public Material[] wallMat; private Renderer surface;    //  the cool shit
    public GameObject fxWallShatter; //  the really cool shit
    void Start()
    {
        //wallStrength = wallStrengthInt;   //  this was working 3 hours ago
        surface = this.GetComponentInChildren<Renderer>();
        surface.material = new Material(wallMat[matnum]);
        //fxCore = GameObject.FindGameObjectWithTag("GameBrain");.GetComponent<FxCore>();   //  this shit don't work yo
    }
    void OnCollisionEnter(Collision other)
    {
        if (wallGrade < 6) //if (matnum < 4) //wallGrade > 0 && 
        {
            wallStrength --;
            if (matnum < 4)
            {
                matnum ++; 
            }
        }
        if (wallStrength <= 0)
        {
            wallGrade --;
            wallStrength = wallStrengthInt;
        }   
        if (wallGrade <= 1 || matnum > 3)
        {
            Instantiate(fxWallShatter, transform.position, transform.rotation);
            //Instantiate(fxCore.fxWallShatter, transform.position, transform.rotation);    //  FUCK i'll have to come back to this
            Destroy(this.gameObject);   
        }
        surface.material = new Material(wallMat[matnum]); 
    }
}