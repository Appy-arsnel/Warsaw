using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    [SerializeField] Transform Muzzle;
    void Start()
    {
        transform.SetParent(Muzzle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
