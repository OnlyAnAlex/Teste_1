using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
           Invoke("Respawn", 2.0f);
        }
    }
    void Reset()
    {
        Instantiate(player);
    }
}
