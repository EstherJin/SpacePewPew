using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnesScript : MonoBehaviour {

    public Sprite Zero;
    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;
    public Sprite Seven;
    public Sprite Eight;
    public Sprite Nine;
    public SpriteRenderer spriteRenderer;

    int levelNumber;
    int onesDigit;

    // Use this for initialization
    void Start () {
	
	}

    void UpdateSprite()
    {
        if (onesDigit == 0)
        {
            spriteRenderer.sprite = Zero;
        }
        else if (onesDigit == 1)
        {
            spriteRenderer.sprite = One;
        }

        else if (onesDigit == 2)
        {
            spriteRenderer.sprite = Two;
        }
        else if (onesDigit == 3)
        {
            spriteRenderer.sprite = Three;
        }
        else if (onesDigit == 4)
        {
            spriteRenderer.sprite = Four;
        }
        else if (onesDigit == 5)
        {
            spriteRenderer.sprite = Five;
        }
        else if (onesDigit == 6)
        {
            spriteRenderer.sprite = Six;
        }
        else if (onesDigit == 7)
        {
            spriteRenderer.sprite = Seven;
        }
        else if (onesDigit == 8)
        {
            spriteRenderer.sprite = Eight;
        }
        else if (onesDigit == 9)
        {
            spriteRenderer.sprite = Nine;
        }
    }

        // Update is called once per frame
        void Update () { 
        onesDigit = (GameManager.level-1) % 10;
        UpdateSprite();
    }
}
