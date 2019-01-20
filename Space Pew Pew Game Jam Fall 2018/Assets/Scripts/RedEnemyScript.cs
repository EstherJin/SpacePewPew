using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyScript : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        if (collision.gameObject.name == "PiercingShot(Clone)" || collision.gameObject.name == "PlayerSpaceShip" || collision.gameObject.name == "Explosion(Clone)")
        {
        }
        else
        {
            Destroy(collision.gameObject);
        }
        if ((PlayerMovement.pierceCount + PlayerMovement.spreadCount + PlayerMovement.bombCount) < 9)
            PlayerMovement.bombCount++;
    }
}
