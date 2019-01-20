using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bluePrefab, greenPrefab, redPrefab;
    GameObject[] preFabList;

    //the ammount of time each enemy will spend on the pattern
    public float patternDuration = 4;
    //the amount of time the whole wave takes
    public float waveDuration = 5;
    //the amount of time between waves
    public float breakTime = 1f;
    //the number of enemies spawned per wave
    public int enemiesPerWave = 9;

    bool onBreak = true;
    static public int level = 1;

    private void Start()
    {
        preFabList = new GameObject[] { bluePrefab, greenPrefab, redPrefab };
    }

	void Update()
	{
		if (Time.time % (waveDuration + breakTime) < breakTime)
		{
			onBreak = true;
			return;
		}
		else if (onBreak)
		{
			onBreak = false;
			float timeDiference = waveDuration - patternDuration;
			float spawnInterval = timeDiference / (enemiesPerWave - 1);
			for (int i = 0; i < EnemyMove.patterns.Length; i++)
			{
				print(string.Format("{0} in {1} : {2}", i, level, ((1 << i) & level) != 0));
				if (((1 << i) & level) != 0)
				{
					for (int j = 0; j < enemiesPerWave; j++)
					{
						Instantiate(preFabList[Random.Range(0,3)], Vector3.up * 100, Quaternion.identity).GetComponent<EnemyMove>()
							.Init(patternDuration, i, spawnInterval * (j + 1), j % 2);
					}
				}
			}
			level++;
		}
	}
}
