using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public static int pierceCount = 1, spreadCount = 1, bombCount = 1;
    public float speed;
    float spriteLifeTime = 0;
    SpriteRenderer spriteRenderer;
    public Sprite idleSprite;
    public Sprite piercingSprite;
    public Sprite spreadSprite;
    public Sprite rocketSprite;
    public GameObject piercingShot;
    public GameObject spreadShotMid;
    public GameObject spreadShotLeft;
    public GameObject spreadShotRight;
    public GameObject rocketShot;
	
	void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

    void FirePiercingshot()
    {
        Instantiate(piercingShot, transform.position + new Vector3(0, 0.75f, 0), Quaternion.identity);
    }

    void FireSpreadShot()
    {
        Instantiate(spreadShotMid, transform.position + new Vector3(0, 0.75f, 0), Quaternion.identity);
        Instantiate(spreadShotLeft, transform.position + new Vector3(0, 0.75f, 0), Quaternion.identity);
        Instantiate(spreadShotRight, transform.position + new Vector3(0, 0.75f, 0), Quaternion.identity);

    }

    void FireRocketShot()
    {
        Instantiate(rocketShot, transform.position + new Vector3(0, 0.75f, 0), Quaternion.identity);
    }
    
    void UpdateSprite()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (pierceCount > 0)
            {
                spriteRenderer.sprite = piercingSprite;
                spriteLifeTime = 0.15f;
                FirePiercingshot();
                pierceCount--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            if (spreadCount > 0)
            {
                spriteRenderer.sprite = spreadSprite;
                spriteLifeTime = 0.15f;
                FireSpreadShot();
                spreadCount--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            if (bombCount > 0)
            {
                spriteRenderer.sprite = rocketSprite;
                spriteLifeTime = 0.15f;
                FireRocketShot();
                bombCount--;
            }
        }
 
        spriteLifeTime -= Time.deltaTime;
        if(spriteLifeTime <= 0)
        {
            spriteRenderer.sprite = idleSprite;
        }
    }
	
	void Update(){
        UpdateSprite();
        float step = speed * Time.deltaTime;
        Vector3 newPos = transform.position;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            newPos += Vector3.left * step;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        {
            newPos += Vector3.right * step;
        }
        newPos.x = Mathf.Clamp(newPos.x, -6.5f,7.5f);
        transform.position = newPos;
	}
}
