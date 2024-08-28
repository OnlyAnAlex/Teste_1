using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    public GameObject banana;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn = 5;
    public float decreaseTime;
    public float minTime = 0.65f;
    public int spawnSide;
    private GameObject[] bananas;
    public float spawnSize;
    public float[] sizes = new float[] {1.5f, 3f, 6f };


    void Start()
    {

        spawnSide = Random.Range(0, 4);
    }
    void Update()
    {
        bananas = GameObject.FindGameObjectsWithTag("Enemy");
        if (bananas.Length <= 0)
        {
            BananaMaker();
        }
    }

    void BananaMaker()
    {
        for (int i = 0; i < (Random.Range (3, 4)); i++)
        {
            {
                Instantiate(banana,
                    new Vector3(Random.Range(-34.0f, 34.0f),
                        Random.Range(-16.0f, 15.0f), 0),
                    Quaternion.Euler(0, 0, 0));
                spawnSize = sizes[Random.Range(1, sizes.Length)];
                banana.transform.localScale = new Vector2(spawnSize, spawnSize);
                spawnSide = Random.Range(0, 4);
                timeBtwSpawn = startTimeBtwSpawn;
            }
        }


    }
}