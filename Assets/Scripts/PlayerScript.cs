using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : FishBehaviour {

    // player movement script
    public bool multiplayerMode;
    public int playerNumber;
    void Update() {

        if (this.multiplayerMode) {

            // player 1 moves with arrow keys, player 2 with WASD
            if (this.playerNumber == 1) {
                if (Input.GetKey(KeyCode.LeftArrow)) {
                    transform.position += Vector3.left * this.speed * Time.deltaTime;
                    FlipPlayer(-1);
                }
                if (Input.GetKey(KeyCode.RightArrow)) {
                    transform.position += Vector3.right * this.speed * Time.deltaTime;
                    FlipPlayer(1);
                }
            } else {
                if (Input.GetKey(KeyCode.A)) {
                    transform.position += Vector3.left * this.speed * Time.deltaTime;
                    FlipPlayer(1);
                }
                if (Input.GetKey(KeyCode.D)) {
                    transform.position += Vector3.right * this.speed * Time.deltaTime;
                    FlipPlayer(-1);
                }
            }
            
        } else {

            float moveHorizontal = Input.GetAxis("Horizontal");
            // moveHorizontal can be -1, 0 o 1 (right, no movement, left)

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
            transform.position += movement * this.speed * Time.deltaTime;
            
            FlipPlayer(moveHorizontal);
        }
    }
}
