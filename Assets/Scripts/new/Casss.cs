using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Casss : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float timetolive;
   
    void Start()
    {
        Destroy(this.gameObject, timetolive);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);


    }
   
}
