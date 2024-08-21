using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rdb;
    private Vector2 direction;
    public float speed;
    public ParticleSystem fogo;
    public static MovePlayer Instance { get; private set; }
    public Transform playerTransform;

    private void Awake()
    {
        if (MovePlayer.Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            playerTransform = transform;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.down;
        transform.position = new Vector3(0, 0, 0);
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        Movement(fogo);
        
    }

    /// <summary>
    /// Função de movimento
    /// </summary>
    void Movement(ParticleSystem fire)
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rdb.AddRelativeForce(Vector2.right * speed * Time.deltaTime);
            fire.Play();
            fire.Emit(1);
        }
        else
        {
            fire.Stop();
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rdb.AddTorque(3 / 2);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rdb.AddTorque(-3 / 2);
        }

    }
}

