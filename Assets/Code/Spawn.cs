using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject banana;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn = 2;
    public float decreaseTime;
    public float minTime = 0.65f;
    public int spawnSide;
    public float spawnSize;
    public float[] sizes = new float[] { 1.5f, 3f, 6f };
    void Start()
    {
        spawnSide = Random.Range(0, 4);
    }

    void Update()
    {
        if(timeBtwSpawn <= 0) {
            if(spawnSide == 0) {
                Instantiate(banana, new Vector2(44f, Random.Range(-20f, 20f)), Quaternion.identity);
                banana.transform.localScale = new Vector2(spawnSize, spawnSize);
                spawnSize = sizes[Random.Range(1, sizes.Length)];
                spawnSide = Random.Range(0, 4);
            }
            else if(spawnSide == 1) {
                Instantiate(banana, new Vector2(-44f, Random.Range(-20f, 20f)), Quaternion.identity);
                banana.transform.localScale = new Vector2(spawnSize, spawnSize);
                spawnSize = sizes[Random.Range(1, sizes.Length)];
                spawnSide = Random.Range(0, 4);
            }
            else if(spawnSide == 2) {
                Instantiate(banana, new Vector2(Random.Range(-8f, 8f), -20f), Quaternion.identity);
                banana.transform.localScale = new Vector2(spawnSize, spawnSize);
                spawnSize = sizes[Random.Range(1, sizes.Length)];
                spawnSide = Random.Range(0, 4);
            }
            else if(spawnSide == 3) {
                Instantiate(banana, new Vector2(Random.Range(-8f, 8f), 20f), Quaternion.identity);
                banana.transform.localScale = new Vector2(spawnSize, spawnSize);
                spawnSize = sizes[Random.Range(1, sizes.Length)];
                spawnSide = Random.Range(0, 4);
            }
            timeBtwSpawn = startTimeBtwSpawn;
        } else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}