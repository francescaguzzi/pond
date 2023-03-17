using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : PlayerBehaviour {

    public Rigidbody2D pebble;
    private float tolerance = 1.0f;

    private void Update() {
            
        if (pebble.transform.position.y > 0.0f) {
            // muovo il giocatore avversario in base alla posizione del sassolino
            if ((pebble.transform.position.x + tolerance) > this.transform.position.x) { // destra
                    
                Vector3 movement = new Vector3(1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                FlipPlayer(-1);
            }
            else if ((pebble.transform.position.x - tolerance) < this.transform.position.x) { // sinistra
                    
                Vector3 movement = new Vector3(-1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                FlipPlayer(1);
            }
        } else {

            // muovo il giocatore avversario in maniera randomica
            // per far sembrare il movimento più naturale
            if (this.transform.position.x > 0.0f) { // destra
                Vector3 movement = new Vector3(-1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                FlipPlayer(1);
            }
            else if (this.transform.position.x < 0.0f) { // sinistra
                Vector3 movement = new Vector3(1, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime;
                FlipPlayer(-1);
            }
            else { // se si trova al centro, lo faccio andare "molto" a destra o a sinistra 

                Vector3 left = new Vector3(-2, 0.0f, 0.0f);
                Vector3 right = new Vector3(2, 0.0f, 0.0f);

                // sorteggio un numero casuale 0 o 1
                int randomNumber = Random.Range(0, 2);

                if (randomNumber == 0) {
                    transform.position += left * this.speed * Time.deltaTime;
                    FlipPlayer(1);
                }
                else {
                    transform.position += right * this.speed * Time.deltaTime;
                    FlipPlayer(-1);
                }

                /* float moveHorizontal = Random.value < 0.5f ? -1.0f : 1.0f;
                Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
                transform.position += movement * this.speed * Time.deltaTime; */

                //transform.position += new Vector3(0.0f, 0.0f, 0.0f);
            }

        }   

    }
     
}
    

