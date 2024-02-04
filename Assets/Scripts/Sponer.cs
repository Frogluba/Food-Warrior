using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponer : MonoBehaviour
{
    public GameObject fruit;
    public float speed = 1f;

     void Start()
    {
        InvokeRepeating("Spawn", 0f, speed);
    }
    void Spawn()
    {
        var obj = Instantiate(fruit);
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x, -5, 0);

    }
}
