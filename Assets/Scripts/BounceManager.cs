using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceManager : MonoBehaviour {
    
    // on every collision, this script increases the speed of the pebble

    public float strenght = 70.0f;

    private void OnCollisionEnter2D(Collision2D collision) {

        Pebble pebble = collision.gameObject.GetComponent<Pebble>();

        if (pebble != null) {

            // get the direction of the collision
            Vector2 direction = collision.contacts[0].point;
            direction = direction.normalized;

            pebble.AddForce(-direction * this.strenght); // negative direction because we want to bounce off the object
        }

    }
}
