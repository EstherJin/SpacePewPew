using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercingShotMovement : MonoBehaviour {
    public float speedPierce;
    float step; 

	void Start(){
        Destroy(gameObject, 10 / speedPierce);
	}
	
	void Update(){
        step = speedPierce * Time.deltaTime;
        transform.position += Vector3.up * step;
	}
}
