using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
	public float yStart;
	public float speed;
	public float height;

	public bool offsetPhase = false;

	SpriteRenderer sr;
	//float height;

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();
		//height = 98;//sr.sprite.bounds.size.y;
		//print(height);
	}

	void Update()
	{
		Scroll();
	}

	void Scroll()
	{
		transform.position = Vector3.up * yStart + Vector3.down * ((Time.time * speed + (offsetPhase ? height / 2f: 0)) % height);
	}
}
