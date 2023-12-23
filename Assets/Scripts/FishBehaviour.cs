using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour {
    
    protected Rigidbody2D rigidBody;
    public float speed = 9.0f;
    private float currentScale;

    void Awake() {
        rigidBody = GetComponent<Rigidbody2D>();
        currentScale = transform.localScale.x;
    }

    // flips the player sprite when moving left or right
    public void FlipPlayer (float moveHorizontal) {

        if (moveHorizontal > 0) { // right
            transform.localScale = new Vector3(-currentScale, currentScale, 1);
        }
        else if (moveHorizontal < 0) { // left
            transform.localScale = new Vector3(currentScale, currentScale, 1);
        }
    }

    public void ResetPlayerPosition() {
        rigidBody.position = new Vector2(0.0f, rigidBody.position.y);
    }

}
