using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pad : MonoBehaviour
{
    public string sceneChange;
    public GameCore gameCore;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.layer == 8)
        {
            SceneManager.LoadScene(sceneChange);
        }
    }
}
