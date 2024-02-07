using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodEntry
{
    public bool isBomb;
    public float x;
    public float delay;
    public bool isRandomPos;
    public Vector2 velocity = new Vector2();
}

[System.Serializable]
public class Wave
{
    public List<FoodEntry> foods;
}


public class Sponer : MonoBehaviour
{
    public GameObject fruit;
    public int bombChance;
    public GameObject bomb;
    public float speed = 1f;
    public int currentWave;
    public List<Wave> waves;

     async void Start()
    {
        while (currentWave<waves.Count)
        {
            var wave = waves[currentWave];
            for (int i = 0; i < wave.foods.Count; i++)
            {
                var food = wave.foods[i];
                await new WaitForSeconds(food.delay);

                var prefab = food.isBomb ? bomb : fruit;
                var go = Instantiate(prefab);
                var x = food.isRandomPos ? Random.Range(-5f, 5f) : food.x;
                go.transform.position = new Vector3(x, -5, 0);
                go.GetComponent<Rigidbody2D>().velocity = food.velocity;

            }
           
            
            await new WaitForSeconds(3f);
            currentWave++;
        }
        
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
