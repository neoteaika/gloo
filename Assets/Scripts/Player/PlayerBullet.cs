using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private bool debugLog = true;
    private AudioSource audioSource;
    public GameObject explosionTest;
    public AudioClip blamn, ricochet;
    public Rigidbody rbody;
    public float speed = 12f, lifespan = 2f;
    public int damage = 14;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rbody = GetComponent<Rigidbody>();
        rbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, lifespan);
    }
    IEnumerator Combust()
    {
        Instantiate(explosionTest, transform.position, transform.rotation);
        Destroy(gameObject);
        yield return null;
    }
    //  bounce and collision scripting
    private int bounce = 0, bounceGrace = 2, bounceMax = 3;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == 6)
        {
            if(bounce <= bounceMax)
            {
                bounce += 1;
                if(debugLog) Debug.Log("Has bounced: " + bounce + " times");
            }
            if(bounce > bounceMax)
            {
                if(debugLog) Debug.Log("Combust! (max bounce)");
                StartCoroutine(Combust());  //  If the bounce limit is reached, the next bounce will force the bomb explosion
            }
        }
        if(other.gameObject.layer == 8 || other.gameObject.layer == 10)
        {
            if (other.gameObject.layer == 8 || bounce <= bounceGrace)
            {
                if(debugLog) Debug.Log("Bounce Grace! " + bounce); // DON'T explode if the total collisions subceeds grace count
                bounce -= 1;
                if(debugLog) Debug.Log("Subtracted 1 bounce, = " + bounce); // "disregard" that bounce from counting should this happen
            }
            else StartCoroutine(Combust());
        }
        /*if(other.transform.root.gameObject.TryGetComponent(out Health health))
        {
            //audioSource.PlayOneShot(blam, 0.7F);
            health.Damage(damage);
            Instantiate(explosionTest, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if(other.relativeVelocity.magnitude > 5)
        {
           //audioSource.PlayOneShot(ricochet, 0.7F);
           Instantiate(explosionTest, transform.position, transform.rotation);
        }*/
    }
}
