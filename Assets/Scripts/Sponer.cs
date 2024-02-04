using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponer : MonoBehaviour
{
    public GameObject fruit;
    public int bombChance;
    public GameObject bomb;
    public float speed = 1f;

     void Start()
    {
        InvokeRepeating("Spawn", 0f, speed);
        
    }
    void Spawn()
    {
        var chance = Random.Range(0, 100);
         var prefab = chance > bombChance ? fruit : bomb;

        var obj = Instantiate(prefab);
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x, -5, 0);

    }
}
