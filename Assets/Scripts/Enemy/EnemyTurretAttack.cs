using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurretAttack : MonoBehaviour
{
    public GameObject turretBulletPrefab;
    public Transform nozzle;
    public float reloadTime = 0.6f;
    public bool reloading;

    public EnemyRadar radar;
    // Start is called before the first frame update
    void Start()
    {
        radar = GetComponent<EnemyRadar>();
    }

    // Update is called once per frame
    void Update()
    {
        if(radar.isActive && !reloading)
            {
                Debug.Log("Fire!");
                Instantiate(turretBulletPrefab, nozzle.position, nozzle.rotation);
                StartCoroutine("Reload");
            }
    }

    // Hold fire until recover time between shots
    IEnumerator Reload()
    {
        reloading = true;
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }
}
