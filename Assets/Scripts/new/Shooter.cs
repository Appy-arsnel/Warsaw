using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooter : MonoBehaviour
{

    [SerializeField] float rateOffire;

    [SerializeField] Projectile projectiles;
  
    



    float nextfireAllowed;
    Transform muzzle;
    public bool canfire;

    void Awake()
    {
       
      
        muzzle = transform.Find("Ak 47/Muzzleposition");

    }
   
    public virtual void Fire()
    {
        canfire = false;


        if (Time.time > nextfireAllowed)
        {
            nextfireAllowed = Time.time + rateOffire;
         
          Instantiate(projectiles, muzzle.position  , muzzle.rotation);
          
            nextfireAllowed = rateOffire;

            canfire = true;
           
        }
        return;
    }
    

}
