using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceManager : MonoBehaviour {
    
    // script che aumenta la velocità della palla ad ogni collisione
    // può essere aggiunto ai giocatori, ai muri o a qualsiasi altro oggetto

    public float strenght = 70.0f;

    private void OnCollisionEnter2D(Collision2D collision) {

        Pebble pebble = collision.gameObject.GetComponent<Pebble>();

        if (pebble != null) {

            // calcolo la direzione in cui deve essere spinta la palla
            Vector2 direction = collision.contacts[0].point;
            direction = direction.normalized;

            pebble.AddForce(-direction * this.strenght); // direzione negativa per invertirla
        }

    }
}
