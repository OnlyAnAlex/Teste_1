using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class FirePlayer : MonoBehaviour

{
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Space))

        {

            Fire();

        }

    }

    void Fire()

    {

        //instanciar o tiro na posicao do player e com a rotacao padrao

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        //adicionar forca para cima no tiro para ele subir

        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 25, ForceMode2D.Impulse);

    }

}

