using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : FishBehaviour {

    // player movement script
    void Update() {

        float moveHorizontal = Input.GetAxis("Horizontal");
        // moveHorizontal can be -1, 0 o 1 (right, no movement, left)

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        transform.position += movement * this.speed * Time.deltaTime;
        
        FlipPlayer(moveHorizontal);
    }
}
