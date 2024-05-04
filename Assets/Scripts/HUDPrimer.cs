using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDPrimer : MonoBehaviour
{
    //  Draw a gizmo in the editor so we know it's around (doesn't show in gameplay)
    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "Relics\\FDISK.png", true);
    }
    #endif

    public GameObject HUDPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(HUDPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
