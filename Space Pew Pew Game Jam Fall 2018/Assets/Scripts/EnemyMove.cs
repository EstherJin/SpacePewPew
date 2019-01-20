using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public static Vector2 offset = new Vector2(-6.5f, -3.5f);
	public static Vector2 scale = new Vector2(14, 8);

	float bufferTime = .3f;
	float startTime, lifeTime;
	int constant;

    Vector2 victoryFlyDirection;

	public static Func<float, int, Vector2>[] patterns = new Func<float, int, Vector2>[]
	{
		Pattern0,
		Pattern1,
		Pattern2,
		Pattern3,
		Pattern4,
		Pattern5,
		/*Pattern6,
		Pattern7,
		/*Pattern8,
		Pattern9,*/
	};

	Func<float, int, Vector2> Pattern;

	void Start()
	{
        float theta = UnityEngine.Random.value * 2 * Mathf.PI;
        victoryFlyDirection = new Vector2(Mathf.Cos(theta), Mathf.Sin(theta));
	}

	public void Init(float lifeTime, int patternIndex, float delay, int constant)
	{
		startTime = Time.time + delay;
		this.lifeTime = lifeTime;
		Pattern = patterns[patternIndex];
		this.constant = constant;
	}

	void Update()
	{
		float t = (Time.time - startTime) / lifeTime;
		if(t < -bufferTime)
		{
			return;
		}
		if(t > 1 + bufferTime)
		{
			Destroy(gameObject);
		}
        if(PlayerLife.lives < 0)
        {
            transform.Translate(victoryFlyDirection * Time.deltaTime * 2);
        }
        else
        {
    		transform.position = ScalePos(Pattern(t, constant));
        }
	}

	static Vector2 ScalePos(Vector2 pos)
	{
		pos.Scale(scale);
		return pos + offset;
	}

	//v line
	static Vector2 Pattern0(float t, int c)
	{
		return new Vector2(
			c * 7f / 14 + 1f / 14,
			1 - t);
	}

	//h line
	static Vector2 Pattern1(float t, int c)
	{
		return new Vector2(
			c == 0 ? t : 1 - t,
			c * .5f + .5f);
	}

	//v tornado
	static Vector2 Pattern2(float t, int c)
	{
		return new Vector2(
			Mathf.Pow(Mathf.Cos(t * 7 * Mathf.PI + Mathf.PI * c), 2) * 3f / 14 + (c * 7f / 14 + 3f / 14),
			1 - t);
	}

	//h tornado
	static Vector2 Pattern3(float t, int c)
	{
		return new Vector2(
			c == 0 ? 1 - t : t,
			Mathf.Pow(Mathf.Cos(t * 7 * Mathf.PI + Mathf.PI * c), 2) * .25f + (c * .5f + .125f));
	}

	//parabola
	static Vector2 Pattern4(float t, int c)
	{
		return new Vector2(
			t,
			2 * (1 + c) * Mathf.Pow(t - .5f, 2));
	}

	//hourglass
	static Vector2 Pattern5(float t, int c)
	{
		return new Vector2(
			(c == 0 ? -1 : 1) * Mathf.Cos(t * 2 * Mathf.PI) * .25f + .25f + c * .5f,
			1 - t);
	}
}
