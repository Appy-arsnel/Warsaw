using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    [SerializeField] GameObject disapper;
    
    void Update()
    {
        Destroy(disapper);
    }
}
