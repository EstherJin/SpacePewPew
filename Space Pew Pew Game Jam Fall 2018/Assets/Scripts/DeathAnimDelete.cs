using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    private void OnEnable()
    {
        Destroy(this.gameObject, .475f);
    }
}
