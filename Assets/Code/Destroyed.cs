using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroyed : MonoBehaviour
{
    public static bool isAlive = true;
    public Rigidbody2D rbd;
    private void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    void Respawn()
    {
        isAlive = true;
        transform.SetPositionAndRotation(new Vector2(0, 0), Quaternion.Euler(0, 0, 0));
        transform.localScale = new Vector3(2, 2, 2);
        rbd.velocity = new Vector2(0, 0);
        rbd.angularVelocity = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            transform.localScale = new Vector3(0, 0, 0);
            isAlive = false;
            Invoke("Respawn", 2f);
        }
    }
    
}
