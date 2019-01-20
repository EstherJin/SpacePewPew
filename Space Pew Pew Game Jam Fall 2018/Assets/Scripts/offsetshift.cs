using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class offsetshift : MonoBehaviour
{

    public float scrollSpeed = 1.0f;
    public float seconds = 0.0f;
    public float units = 13.17715959f;
    float startTime = 0.0f;


    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        transform.position = new Vector3(0, (Time.time - (units/2)) % units);
    }


}