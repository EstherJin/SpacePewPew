using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BombShotMovement: MonoBehaviour
{
    Collision col;

    public float speedBomb;
    public float bombRotateSpeed;
    float step;

    public GameObject Explosion;


    void Start()
    {
        Destroy(gameObject, 10 / speedBomb);
    }

    void Update()
    {

        step = speedBomb * Time.deltaTime;
        transform.position += Vector3.up * step;
        transform.Rotate(Vector3.forward * step * bombRotateSpeed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        Instantiate(Explosion, this.transform.position, Quaternion.identity);
    }
}
