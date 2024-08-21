using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour
{
    public Rigidbody2D rbd;
    private void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    void Respawn()
    {
        transform.SetPositionAndRotation(new Vector2(0, 0), Quaternion.Euler(0, 0, 0));
        rbd.velocity = new Vector2(0, 0);
        rbd.angularVelocity = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            transform.position = new Vector2(600, 600);
            Invoke("Respawn", 2f);
        }
    }
    
}
