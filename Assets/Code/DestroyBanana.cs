using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBanana : MonoBehaviour
{
    void OnParticleCollisionEnter2D()
    {
        if (gameObject.transform.localScale.magnitude >= 3)
        {
            Destroy(gameObject);
            transform.localScale = transform.localScale / 2;
            Instantiate(gameObject);
        }

        else
        {
            Destroy(gameObject);
            Destroy(gameObject);
        }
    }
}
