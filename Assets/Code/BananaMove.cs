using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class BananaMove : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform bananaPos;
    private Transform normalizeDirection;
    private Vector2 RandomPlace;
    Transform playerTransform;
    Vector3 position;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        rb.AddForce(Random.insideUnitCircle.normalized * Random.Range(-500.0f, 750.0f));

        // Give a random angular velocity/rotation
        rb.angularVelocity = Random.Range(-0.0f, 90.0f);
    }
     void Update()
    {
     
    }
}
