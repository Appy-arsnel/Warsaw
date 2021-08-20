using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public InputController InputController;
    Animator anim;
    private float inputH;
    private float inputV;
    [SerializeField] Playeraim playeraim;

    
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Horizontal",InputController.Horizontal);
        anim.SetFloat("Vertical", InputController.Vertical);
        anim.SetBool("isWalking", InputController.isWalking);
        anim.SetBool("isSprint", InputController.isSpriting);
        anim.SetBool("isJumping", InputController.isJumping);
        anim.SetBool("isCrouched", InputController.isCrouched);
        anim.SetBool("isAiming", InputController.Fire1);
        anim.SetFloat("Aimangle", playeraim.GetAngle());
    }


}
