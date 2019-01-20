using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Vector3 DeletePos;
    public Vector3 StartPos;
    float axis;
    float a;
    float starty;

    // Use this for initialization
    void Start () {
        DeletePos = new Vector3(0, -6, 0);
        StartPos = new Vector3(0, 5, 0);
    }

    private void OnEnable()
    {
        axis = transform.position.x;
        starty = transform.position.y;
    }

    // Update is called once per frame
    void Update () {
        float a = starty - transform.position.y;
        float x = 2 * Mathf.Cos(a * Mathf.PI);
        if ( transform.position.y <= DeletePos[1]){
            Destroy(this.gameObject);
        }

        Vector3 pathToFollow = new Vector3(x + axis, transform.position.y - .05f, 0);
         transform.position = pathToFollow;
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("heyo");
        Destroy(this.gameObject);
        if(collision.gameObject.name == "Bomb" || collision.gameObject.name == "SpreadShot" || collision.gameObject.name == "Bomb(Clone)" || collision.gameObject.name == "SpreadShot(Clone)")
        {
            Destroy(collision.gameObject);
        }

        Debug.Log(collision.gameObject.name);

    }


}
