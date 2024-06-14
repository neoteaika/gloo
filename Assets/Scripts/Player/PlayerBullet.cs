using System.Collections; using System.Collections.Generic; using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public AudioCore audioCore; private AudioSource audioSource; public float volSFX = 1;    //fuck this shit pt.1
    private bool debugLog = true;
    public GameObject fxExplosion;
    public Rigidbody rbody;
    public float speed = 12f, lifespan = 2f; public int damage = 14;
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioCore = GameObject.FindGameObjectWithTag("AudioBrain").GetComponent<AudioCore>(); //fuck this shit pt.2
    }
    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
        rbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, lifespan);
    }
    IEnumerator Combust()
    {
        Instantiate(fxExplosion, transform.position, transform.rotation);
        //RaycastHit
        Destroy(gameObject);
        yield return null;
    }
    ///
    /// +++ BOUNCE AND COLLISION LOGIC +++ ///
    ///
    [SerializeField] private int bounce = 0, bounceGrace = 2, bounceMax = 3;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == 6)
        {
            if(bounce <= bounceMax)
            {
                bounce += 1;
                if(debugLog) Debug.Log("Has bounced: " + bounce + " times");
                audioCore.audioSource.PlayOneShot(audioCore.sfxBombBounce, volSFX); //fuck this shit pt.3
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
        if(other.gameObject.layer == 10)
        {
            StartCoroutine(Combust());
        }
        //health.Damage(damage);
    }
}
