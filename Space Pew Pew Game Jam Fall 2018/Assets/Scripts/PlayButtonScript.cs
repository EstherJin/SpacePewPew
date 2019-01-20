using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour {
    public Sprite Hover,noHover;
    SpriteRenderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnMouseOver()
    {
        rend.sprite = Hover;
    }
    private void OnMouseExit()
    {
        rend.sprite = noHover;
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
