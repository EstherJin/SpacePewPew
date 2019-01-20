using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PierceNum : MonoBehaviour {
    SpriteRenderer spriteRenderer;
    public Sprite num0, num1, num2, num3, num4, num5, num6, num7, num8, num9;
    Sprite[] spriteList;
	void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteList = new Sprite[10] { num0, num1, num2, num3, num4, num5, num6, num7, num8, num9 };
    }
	
	void Update () {
        spriteRenderer.sprite = spriteList[PlayerMovement.pierceCount];
	}
}
