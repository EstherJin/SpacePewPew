using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public static int lives = 3;
    public GameObject Explosion;
    public bool alive = true;
    public SpriteRenderer rend;
    public BoxCollider2D hitbox;
    Vector3 startPosition = new Vector3(0, -4.5f, 0);
    void Start()
    {
        rend.enabled = true;
        hitbox.enabled = true;
        //rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(lives < 0){
            StartCoroutine(delay());
            rend.enabled = false;
            hitbox.enabled = false;
            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rend.enabled = false;
        hitbox.enabled = false;
        lives--;
        if(lives < 0)
        {
            return;
        }
        Instantiate(Explosion, transform.position, Quaternion.identity);
        transform.position = startPosition;
        StartCoroutine(InvincibilityFrames());
    }

    public IEnumerator InvincibilityFrames(){
        Debug.Log("Hit");
        for (int i = 6; i > 0; i-- )
        {
            yield return new WaitForSeconds(.2f);
            rend.enabled = true;
            yield return new WaitForSeconds(.2f);
            rend.enabled = false;
        }
        rend.enabled = true;
        hitbox.enabled = true;
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("GameOver");
    }
}