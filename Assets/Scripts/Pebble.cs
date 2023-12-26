using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pebble : MonoBehaviour {

    public float speed = 130.0f;
    private Rigidbody2D rigidBody;
    
    void Awake() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Start() {

        ResetPosition();
        Invoke("AddInitialForce", 1.0f); // wait 1 second before adding force
    }

    void Update() {

        // if the pebble is moving too fast, reset its position
        if (rigidBody.velocity.magnitude > 40.0f) {
            ResetPosition();
            Invoke("AddInitialForce", 1.0f); // wait 1 second before adding force
        }
    }

    public void AddInitialForce() {

        float x = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        float y = Random.value < 0.5f ? -1.0f : 1.0f;
        
        Vector2 direction = new Vector2(x, y);

        rigidBody.AddForce(direction * this.speed);

    }

    public void AddForce(Vector2 force) {
        rigidBody.AddForce(force);
    }

    public void ResetPosition() {
        rigidBody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    
}
