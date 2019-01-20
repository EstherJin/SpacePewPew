using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class shiftMid : MonoBehaviour
{

    public float scrollSpeed = 1.0f;
    public float seconds = 0.0f;
    float startTime = 0.0f;
    public float units = 180f;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        transform.position = transform.up * Time.deltaTime * -scrollSpeed * (Time.time % units);
    }


}