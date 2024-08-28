using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticle : MonoBehaviour
{
    public ParticleSystem playerParticle;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Destroyed.isAlive == true)
        {
            Fire();
        }
    }
    void Fire()
    {
        playerParticle.Emit(1);
    }
}