using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    string[] patterns = { "h-line", "v-line", "following-v-line" };
    public float spawnTime = 3f;
    public int size = 4;
    public GameObject SquareEnemy;
    public GameObject TriangleEnemy;
    public GameObject EggEnemy;
    Vector3 spawnPosition;
    public GameObject[] typesOfEnemies;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        Debug.Log(typesOfEnemies);
        spawnPosition = this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        spawnPosition = this.transform.position;
        string patternToGenerate = patterns[Random.Range(0,3)];
        Debug.Log(patternToGenerate);
        if (patternToGenerate == "h-line")
        {
            int offset = 3;

            for (int i = size; i > 0; i--)
            {
                Instantiate(typesOfEnemies[Random.Range(0, 3)], spawnPosition, this.transform.rotation);
                spawnPosition[0] += offset;
            }
        }
        if (patternToGenerate == "v-line")
        {
            int offset = 2;

            for (int i = size; i > 0; i--)
            {
                spawnPosition[1] += offset;
                Instantiate(typesOfEnemies[Random.Range(0, 3)], spawnPosition, this.transform.rotation);

            }
        }
        if (patternToGenerate == "following-v-line")
        {


            StartCoroutine(SpawnDelay());
        }
    }


    public IEnumerator SpawnDelay()
    {
        for (int i = size; i > 0; i--)
        {
            yield return new WaitForSeconds(.25f);
            Instantiate(typesOfEnemies[Random.Range(0, 3)], spawnPosition, this.transform.rotation);
        }
        Debug.Log("Pls help");
    }

}
