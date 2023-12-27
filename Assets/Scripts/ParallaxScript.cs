using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    // script that slowly moves the background to create a parallax effect
    // right - left movement

    private float speed = 1f;
    private Vector3 startPosition;
    private int direction = 1;

    void Start() {
        startPosition = transform.position;
    }
    void Update() {

        // max x position is 5, min x position is -5
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        if (transform.position.x >= 4.9f) 
            direction = -1; 
        else if (transform.position.x <= -4.9f)
            direction = 1; 
        
    }
}
