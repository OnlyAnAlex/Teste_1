using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private float scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 4f);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && other.gameObject.transform.localScale.magnitude >= 3)
        {
            Destroy(gameObject);
            other.transform.localScale = other.transform.localScale / 2;
            Instantiate(other.gameObject);
        }

        else if (other.gameObject.CompareTag("Enemy") && other.gameObject.transform.localScale.magnitude < 3)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}