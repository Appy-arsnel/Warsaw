using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
   
    [SerializeField] float speed;
    [SerializeField] float timetolive;
    [SerializeField] float damage;
    void Start()
    {
        Destroy(this.gameObject, timetolive);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        print("Hit!"+ other.name);
        Heakth target = other.GetComponent<Heakth>();
        if (target != null)
        {
            target.Takedamage(damage);
        }
    }
}
