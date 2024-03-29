﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFootSoldier : MonoBehaviour {


    // Variable lets us add to the score.
    // Public so we can drag and drop.
    public Score scoreObject;
    // Variable to hold the coin's poin value.
    // Public so we can change it in the editor.
    public int coinValue;
    public Animator EnemyAnimator;


    public GameObject enemyBullet;
    Vector2 bulletPos;
    public float fireRate = 4f;
    float nextFire = 0.0f;



    // Unity calls this function automatically
    // When our bullet touches any other object
    private void OnCollisionEnter2D(Collision2D collsion)
    {

        //Check if the thing that we collided with is the player or bullet
        Player playerScript = collsion.collider.GetComponent<Player>();
        Bullet playersBulletScript = collsion.collider.GetComponent<Bullet>();
        // Only do something if the thing we run into was in fact the player (aka playerScript is not null)

        if (playerScript != null)
        {
            // We DID hit the player!

            //KILL THEM!
            playerScript.Kill();
        }

        else

         if (playersBulletScript != null && playersBulletScript.isPlayer == true)
        {
            // We DID hit the enemy

            // Add to the score based on our value.



            // Kill the enemy!!!
            Destroy(gameObject);



            // Add score per dead enemy!
            scoreObject.AddScore(coinValue);

            Destroy(playersBulletScript.gameObject);


        }





    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Firing the Chaos Marines Bolter
        if (Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;
            fire();

        }
    }


    // Enemy firing a MUSKET at the player.
    void fire()
    {
        bulletPos = transform.position;

        // if the enemy has bullet assigned.
        if (enemyBullet != null)
        {
            // Firing the bullet at the level of the enemy musket (in order not to shoot from for example a knee cap).
            bulletPos += new Vector2(-0.70f, +0.29f);


            Instantiate(enemyBullet, bulletPos, Quaternion.identity);

            EnemyAnimator.SetTrigger("enemyFire");

        }


    }


}
