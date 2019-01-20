using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class shift : MonoBehaviour
{
    public float scrollSpeed;
    float startTime = 0;
    void Start()
    {
        startTime = Time.time;
    }
    void update()
    {
        Vector2 offset = new Vector2(0,(Time.time - startTime) * scrollSpeed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}