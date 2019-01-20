using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHubLives : MonoBehaviour {
    public Sprite threeLife, twoLife, oneLife, noLife;
    Sprite[] numLives;
    SpriteRenderer rend;
	void Start(){
        numLives = new Sprite[4] { noLife, oneLife, twoLife, threeLife };
        rend = GetComponent<SpriteRenderer>();
    }
	
	void Update(){
        if (PlayerLife.lives > -1)
        {
            rend.sprite = numLives[PlayerLife.lives];
        }
	}
}
