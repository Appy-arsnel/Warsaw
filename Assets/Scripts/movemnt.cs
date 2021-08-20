using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class movemnt : MonoBehaviour
{
    public Playeraim playeraim;
    public float speed = 5f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Transform playerCameraParent;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 60.0f;
    public float nlookXLimit = 60.0f;
    public float height;

    InputController inputcontroller;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    Vector2 rotation = Vector2.zero;

    [HideInInspector]
    public bool canMove = true;

    void Start()
    {
        inputcontroller = GameManager.Instance.InputController;
        characterController = GetComponent<CharacterController>();
        rotation.y = transform.eulerAngles.y;
        height = characterController.height;
      
    }

    void Update()
    {
        if (characterController.isGrounded)
        {

            if (Input.GetButton("Crouch") && canMove)
                {
             
                speed = 2.5f;
                

            }   
            else
            {
                speed = 5f;
            
            }
            if (Input.GetButton("Sprint") && canMove)
            {
                speed = 15f;

            }
            else
            {
                speed = 5f;
            }
            if (Input.GetButton("ToggleWalk") && canMove)
            {
                speed = 3.5f;
            }

            else
            {
                speed = 5f;
            }
            
                Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            float curSpeedX = canMove ? speed * Input.GetAxis("Vertical") : 0;
            float curSpeedY = canMove ? speed * Input.GetAxis("Horizontal") : 0;
            float movementDirectionY = moveDirection.y;
            moveDirection = (forward * curSpeedX) + (right * curSpeedY);
          
            
            

            if (Input.GetButton("Jump") && canMove)
            {
                moveDirection.y = jumpSpeed;



            }
            else
            {
                moveDirection.y = movementDirectionY;
            }

           


        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

       





        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Player and Camera rotation
       if (canMove)
            {
                rotation.y += Input.GetAxis("Mouse X") * lookSpeed;
                rotation.x += -Input.GetAxis("Mouse Y") * lookSpeed;
                rotation.x = Mathf.Clamp(rotation.x, -lookXLimit, nlookXLimit);
                playerCameraParent.localRotation = Quaternion.Euler(rotation.x, 0, 0);
                transform.eulerAngles = new Vector2(0, rotation.y);


            playeraim.SetRotation(Input.GetAxis("Mouse Y") * 5f);
            }
    }



}