using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    
    private void OnParticleCollision(GameObject other)
    {
        if (gameObject.transform.localScale.magnitude >= 3)
        {
            transform.localScale = transform.localScale / 2;
            Instantiate(gameObject);
        }

        else if (gameObject.transform.localScale.magnitude < 3)
        {
            Destroy(gameObject);
        }
    }
}