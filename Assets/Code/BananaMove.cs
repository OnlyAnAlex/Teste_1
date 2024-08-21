using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class BananaMove : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 10;
    public Transform bananaPos;
    private float RandomX = 0;
    private float RandomY = 0;
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
        if (MovePlayer.Instance != null)
        {
            playerTransform = MovePlayer.Instance.playerTransform;
            position = playerTransform.position;
        }
        
        RandomPlace = new Vector2(Random.Range(RandomX, -RandomX), Random.Range(RandomY, -RandomY));
        speed = Random.Range(2, 8);
        rb.AddForce(Vector2.MoveTowards(bananaPos.position, RandomPlace, speed * Time.deltaTime * 20));
    }
     void Update()
    {
        if (transform.position.x > position.x)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        }
        else if (transform.position.x < position.x)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        }
        if (transform.position.y >= position.y)
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;
        }
        else if (transform.position.y < position.y)
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
        }
    }
}
