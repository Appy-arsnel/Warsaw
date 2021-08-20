using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fpssss : MonoBehaviour
{
    public Transform muzzle;

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(muzzle);
    }
}
