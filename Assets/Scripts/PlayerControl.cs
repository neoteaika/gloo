using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  CONTROLLER V2 - This is based on using Unity's AnimatorController to animate Gloo as we move around
public class PlayerControl : MonoBehaviour
{
    public Animator anim;
    private float horizontalInput;  // Store the hor/ver axis inputs to the player object
    private float verticalInput;

    public bool useAbsoluteMotion;  // Move up when I say up, damnit!
    public bool usePhysicalMotion;  //  PhysX ain't got jack!

    public float translateSpeed = 5f;  // Movement speed
    public float physicalSpeed = 60f;
    
    void Start()
    {

    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * translateSpeed;
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * translateSpeed;
        //Debug.Log(horizontalInput); //  Just to make sure we are actually getting the inputs
        //Debug.Log(verticalInput);
        if (useAbsoluteMotion)
        {
            // use absolute
            transform.Translate(horizontalInput, 0f, verticalInput, Space.World);
        } else if (usePhysicalMotion)
        {
             // use forces
            GetComponent<Rigidbody>().AddForce(horizontalInput * physicalSpeed, 0f, verticalInput * physicalSpeed);
        } else {
            // use relative
            transform.Translate(horizontalInput, 0f, verticalInput);
        }
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //  Get screen>world space from camera
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition.y = 0f;   //  Zero out Y value
        //transform.LookAt(mousePosition);
        //Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        //Debug.DrawRay(transform.position, newDir, Color.red);
 
        //transform.rotation = Quaternion.LookRotation(newDir);
    }
}

/*  //  OLDER CONTROLLER V1
public class PlayerControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //  ++  PLAYER MOVEMENT ++
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * translateSpeed;
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * translateSpeed;
        // Apply inputs to object transform
        if (useAbsoluteMotion)
        {
            // use absolute
            transform.Translate(horizontalInput, 0f, verticalInput, Space.World);
        } else {
            // use relative
            transform.Translate(horizontalInput, 0f, verticalInput);
        }
        //  ++  MOUSE TRACKER   ++
        //  Debug.Log(Input.mousePosition);
        //  Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //  Get screen>world space from camera
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 0f;   //  Zero out Y value
        transform.LookAt(mousePosition);
    }
}
*/