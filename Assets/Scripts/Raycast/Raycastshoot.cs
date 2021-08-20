using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastshoot : MonoBehaviour
{
    public Camera fps;
    [SerializeField] float damage;
    [SerializeField] Transform hand;
    [SerializeField] ParticleSystem muzzleflash;
    void Start()
    {
        
    }
    void Update()
    {

        if (GameManager.Instance.InputController.Fire1)
        {
           Shoot();
            muzzleflash.Play();
        }


    }

    void Shoot()
    {
      
        RaycastHit hit;
        if(Physics.Raycast(fps.transform.position,fps.transform.forward,out hit))
        {
            Debug.Log(hit.transform.name);

            Heakth target = hit.transform.GetComponent<Heakth>();
            if (target!=null)
            {
                target.Takedamage(damage);
            }
        }
      
       
    }

}
