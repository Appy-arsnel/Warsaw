using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assaultriffle : Shooter
{
   
    void Start()
    {
        
    }
    public override void Fire ()
    {
        base.Fire();
       if (canfire)
        {
            //we fire.
        }
    }
    
}
