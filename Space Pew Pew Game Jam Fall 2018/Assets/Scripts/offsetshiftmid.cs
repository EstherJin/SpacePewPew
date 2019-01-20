using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class offsetShiftMid : MonoBehaviour
{

    public float scrollSpeed = 1.0f;
    public float seconds = 0.0f;
    public float units = 130f;
    float startTime = 0.0f;


    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        transform.position = transform.up * Time.deltaTime * -scrollSpeed * ((Time.time - (units/2)) % units);
    }


}