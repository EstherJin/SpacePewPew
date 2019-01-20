using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour {
    public bool[] pewPewChace = { true, false, false, false, false };
    bool willPewPew;
    public GameObject bullet;
    bool trigger = false;
    Vector3 pewPewSpawn;
    // Use this for initialization
    void Start () {
		
	}

    private void OnEnable()
    {
        willPewPew = pewPewChace[Random.Range(0, 5)];

        if (willPewPew == true)
        {
            trigger = true;
        }
        StartCoroutine(PewPewTimer());
    }

    IEnumerator PewPewTimer()
    {
        while (trigger == true)
        {
            yield return new WaitForSeconds(1.5f);
            pewPewSpawn = new Vector3(this.transform.position.x, this.transform.position.y - .8f, 0);
            Instantiate(bullet, pewPewSpawn, Quaternion.identity);
        }
    }
}
