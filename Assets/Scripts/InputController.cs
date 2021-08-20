using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float Vertical;
    public float Horizontal;
    public Vector2 MouseInput;
    public bool isWalking=false;
   
    public bool isCrouched=false;
    public bool isSpriting=false;
    public bool isJumping=false;
    public bool Fire1=false;


  
    // Update is called once per frame
    void FixedUpdate()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        MouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        if (Input.GetButton("ToggleWalk"))
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        if (Input.GetButton("Sprint"))
        {
            isSpriting = true;
        }
        else
        {
            isSpriting = false;
        }

        if (Input.GetButton("Crouch"))
        {
            isCrouched = true;
         
        }
        else
        {
            isCrouched = false;
        }

        if (Input.GetButton("Jump"))
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }
       
        if (Input.GetButton("Fire1"))
        {
            Fire1 = true;
        }
        else
        {
            Fire1 = false;
        }
    }
}
