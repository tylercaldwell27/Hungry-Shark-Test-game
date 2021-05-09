using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject goodFish;
    public GameObject badFish;
    public bool stopSpawning = false;
    public float spawnTime;
    public float delayTime;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 2000;
        InvokeRepeating("SpawnObject", spawnTime, delayTime);
    }

    // Update is called once per frame
    void Update()
    {
       
        //timer to know when to spawn in next fish
        if (spawnTime <= 0)
        {
            SpawnFish();
            spawnTime = 2000;
        }
        else
        {
            spawnTime -= 1;
        }
    }

    void SpawnFish()
    {
        int randomFish = Random.Range(1, 100);
        Debug.Log(randomFish);
        if (randomFish <= 50)
        {
            Instantiate(goodFish, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(badFish, transform.position, transform.rotation);
        }
    }
}
