using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjActionZone : MonoBehaviour
{
    SpriteRenderer m_spriteRenderer;
    
    public Sprite[] sprites;
    void Start()
    {
        m_spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            m_spriteRenderer.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            m_spriteRenderer.enabled = false;
        }
    }
}