using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 20;
    public int healthReset = 20;

    public void Damage(int damage)
    {
        Debug.Log("DAMAGE" + damage);
        health -= damage;
        if(health <= 0)
        {
            Debug.Log("DETH!");
        }
    }

    public void RecoverFull()
    {
        health += healthReset;
    }
}
