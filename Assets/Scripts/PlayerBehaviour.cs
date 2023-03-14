using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    
    public Rigidbody2D rigidBody;
    public float speed = 9.0f;

    void Awake() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // funzione per invertire il giocatore a seconda della direzione
    public void flipPlayer (float moveHorizontal) {

        // recupero i valori di scala attuali
        float yScale = transform.localScale.y;
        float xScale = transform.localScale.x;

        if (moveHorizontal > 0) {
            transform.localScale = new Vector3(-1, yScale, 1);
        }
        else if (moveHorizontal < 0) {
            transform.localScale = new Vector3(1, yScale, 1);
        }
    }

}
