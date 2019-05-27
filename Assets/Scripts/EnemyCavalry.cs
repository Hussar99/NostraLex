using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCavalry : MonoBehaviour {


    public Score scoreObject;
    // Variable to hold the coin's poin value.
    // Public so we can change it in the editor.
    public int coinValue;
 


    // Unity calls this function automatically
    // When our enemy touch any other object
    private void OnCollisionEnter2D(Collision2D collsion)
    {

        //Check if the thing that we collided with is the player (aka has a Player script)
        Player PlayerScript = collsion.collider.GetComponent<Player>();
        Bullet playersBulletScript = collsion.collider.GetComponent<Bullet>();
        // Only do something if the thing we run into was in fact the player (aka playerScript is not null)

        if (PlayerScript != null)
        {
            // We DID hit the player!

            //KILL THEM!
            PlayerScript.Kill();
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


}
