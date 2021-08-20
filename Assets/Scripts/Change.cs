using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    [SerializeField] Camera tpp;
    [SerializeField] Camera fpp;
    void Start()
    {
        tpp.enabled=true;
        fpp.enabled = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("tpp/fpp"))
        {
            if (tpp.enabled)
            {
                tpp.enabled = false;
                fpp.enabled = true;
            }
            else if(!tpp.enabled)
            {
                tpp.enabled = true;
                fpp.enabled = false;
            }
           
        }
        
    }
}
