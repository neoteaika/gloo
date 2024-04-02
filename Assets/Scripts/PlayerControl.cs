using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;  // Store the hor/ver axis inputs to the player object
    private float verticalInput;
    public float translateSpeed = 10f;  // Movement speed
    public bool useAbsoluteMotion;  // Move up when I say up, damnit!
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  ++  PLAYER MOVEMENT ++
        // Debug.Log(Input.GetAxis("Horizontal"));
        // Debug.Log(Input.GetAxis("Vertical"));
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
