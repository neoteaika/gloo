using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 20, healthReset = 20;

    public void Damage(int damage)
    {
        //Debug.Log("DAMAGE" + damage);
        health -= damage;
        if(health <= 0)
        { //Debug.Log("DETH!");
            if (gameObject.TryGetComponent(out Death death))
            {
                death.HandleDeath();
            }
            else
            {
                Debug.Log("No death script present, dumbass!");
            }
        }
    } 

    public void RecoverFull()
    {
        health += healthReset;
    }
}
