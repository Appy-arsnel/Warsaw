using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sET : MonoBehaviour
{
    [SerializeField] Transform hand;
    void Start()
    {
        transform.SetParent(hand);
    }

    
}
