using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  CONTROLLER V2 - This is based on using Unity's AnimatorController to animate Gloo as we move around
public class PlayerControl : MonoBehaviour
{
    public static bool playerControlFocus = true;
    public Animator anim;   //  For anims
    private float horizontalInput, verticalInput,
    lookDir, moveDir, translateSpeed = 5f;  // Store the hor/ver axis inputs & move speeds
    public bool useAbsoluteMotion;  // Move up when I say up, damnit! PhysX ain't got jack.
    
    void Update()
    {
        //  ++  CHECKSAHEAD ++  ??
        GetComponent<DialogCore>();
        //  ++  MOVEMENT STUFF  ++  //
        if (!playerControlFocus) {return;}  //  Early break/prevent input response (Dialog, cinematics, modals)
        
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * translateSpeed;
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * translateSpeed;
        
        if (useAbsoluteMotion)
        {
            // use absolute
            transform.Translate(horizontalInput, 0f, verticalInput, Space.World);
        } else {
            // use relative
            transform.Translate(horizontalInput, 0f, verticalInput);
        }

        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        Vector3 lookDir = transform.position + moveDir;
        transform.LookAt(lookDir);
    }
}