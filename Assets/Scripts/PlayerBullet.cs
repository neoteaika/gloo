using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip ricochet;
    public AudioClip blam;
    public Rigidbody rbody;
    public float speed = 12f;
    public float lifespan = 4f;
    public int damage = 14;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rbody = GetComponent<Rigidbody>();
        rbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, lifespan);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent(out Health health))
        {
            audioSource.PlayOneShot(blam, 0.7F);
            health.Damage(damage);
            Destroy(gameObject);
        }
        if(other.relativeVelocity.magnitude > 5)
        {
           audioSource.PlayOneShot(ricochet, 0.7F);
        }
    }
}
