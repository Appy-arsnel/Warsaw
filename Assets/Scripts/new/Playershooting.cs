using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershooting : MonoBehaviour
{
    
    [SerializeField] Shooter assaultrifle;
   
    
    void FixedUpdate()
    {
        if (GameManager.Instance.InputController.Fire1)
        {
            assaultrifle.Fire();
           
        }
    }

}
