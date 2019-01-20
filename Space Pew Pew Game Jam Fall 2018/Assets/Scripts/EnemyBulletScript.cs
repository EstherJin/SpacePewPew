using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour {
    float bulletSpeed = -.125f;
    public Vector3 DeletePos;
    // Use this for initialization
    void Start () {
        DeletePos = new Vector3(0, -6.5f, 0);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y + bulletSpeed, 0);
        if (transform.position.y <= DeletePos[1])
        {
            Destroy(this.gameObject);
        }
    }
}
