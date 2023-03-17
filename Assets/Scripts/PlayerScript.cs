using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : FishBehaviour {

    // muovo il giocatore con le frecce
    void Update() {

        float moveHorizontal = Input.GetAxis("Horizontal");
        // moveHorizontal può essere -1, 0 o 1 (a seconda se si preme sinistra, nessuna o destra)

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        transform.position += movement * this.speed * Time.deltaTime;
        
        FlipPlayer(moveHorizontal);
    }
}
