using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimationScript : MonoBehaviour {


    public GameObject death;
    void Start () {
		
	}

	void Update () {
		
	}

    private void OnDestroy()
    {
        Instantiate(death, transform.position, transform.rotation);
    }
}
