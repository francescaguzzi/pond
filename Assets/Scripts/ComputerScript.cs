using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : PlayerBehaviour {

    public Rigidbody2D pebble;


    private void Update() {
            
        if (pebble.transform.position.y > 0.0f) {
            // muovo il giocatore avversario in base alla posizione del sassolino
            if (pebble.transform.position.x > this.transform.position.x) { // destra
                    
                Vector3 movement = new Vector3(1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                flipPlayer(-1);
            }
            else if (pebble.transform.position.x < this.transform.position.x) { // sinistra
                    
                Vector3 movement = new Vector3(-1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                flipPlayer(1);
            }
        } else {

            // muovo il giocatore avversario in maniera randomica
            if (this.transform.position.x > 0.0f) { // destra
                Vector3 movement = new Vector3(-1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                flipPlayer(-1);
            }
            else if (this.transform.position.x < 0.0f) { // sinistra
                Vector3 movement = new Vector3(1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                flipPlayer(1);
            }

        }   

    }
     
}
    

