using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heakth : MonoBehaviour
{
    public float health = 50f;
    public void Takedamage(float amount)
    {
        health -= amount;
        if(health<=0f)
        {
            Die();
        }
    }
    
 
    void Die()
    {
        Destroy(gameObject);
    }
}
