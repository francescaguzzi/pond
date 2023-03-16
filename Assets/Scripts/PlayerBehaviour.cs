using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    
    protected Rigidbody2D rigidBody;
    public float speed = 9.0f;

    void Awake() {
        
        // recupero il componente rigidBody del giocatore
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // funzione per invertire il giocatore a seconda della direzione
    public void FlipPlayer (float moveHorizontal) {

        if (moveHorizontal > 0) { // destra
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveHorizontal < 0) { // sinistra
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void ResetPlayerPosition() {
        rigidBody.position = new Vector2(0.0f, rigidBody.position.y);
    }

}
