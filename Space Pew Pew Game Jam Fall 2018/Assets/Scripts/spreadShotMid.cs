using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spreadShotMid : MonoBehaviour
{

    public float speed = 10.0f;
    public float seconds = 0.0f;
    public float angle = 0f;
    float startTime = 0.0f;

    void Start()
    {

        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        transform.position += transform.up * Time.deltaTime * speed;
        if (transform.position.y >= 8)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);

    }
}
