
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EuclideanTorus : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        // Teleport the game object
        if (transform.position.x > 35)
        {

            transform.position = new Vector3(-35, transform.position.y, 0);

        }
        else if (transform.position.x < -35)
        {
            transform.position = new Vector3(35, transform.position.y, 0);
        }

        else if (transform.position.y > 16)
        {
            transform.position = new Vector3(transform.position.x, -16, 0);
        }

        else if (transform.position.y < -16)
        {
            transform.position = new Vector3(transform.position.x, 16, 0);
        }
    }
}