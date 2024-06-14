using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTestScript : MonoBehaviour
{

    /// fuck every single component of this explosion idea
    private bool debugLog = true;
    public int damage = 10;
    public int radius = 2;

    void Awake()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (var hitCollider in hitColliders)
        {
            if(debugLog) Debug.Log("explosiontouch");
            if(hitCollider.TryGetComponent(out Health health))
            {
                health.Damage(damage);
                Destroy(gameObject);
            }
            if(hitCollider.TryGetComponent(out WallScript wallStrength))
            {
                wallStrength.Damage(damage);
                Destroy(gameObject);
            }
        }
    }
}
