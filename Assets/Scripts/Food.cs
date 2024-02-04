using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,Random.Range(7,13) );
        rb.angularVelocity = Random.Range(-360, 360);
       
    }

    
    void Update()
    {
        if(transform.position.y <-6)
        {
            print("D:");
            Destroy(gameObject);
        }
    }
}
