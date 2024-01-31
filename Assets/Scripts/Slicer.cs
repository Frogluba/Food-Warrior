using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;
        rb.MovePosition(mousepos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(":D");
        Destroy(collision.gameObject);
    }
}
