using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : FishBehaviour {
            
    public Rigidbody2D pebble;
    [SerializeField]
    private float tolerance = 1.0f;

    private Vector3 direction = Vector3.zero;
    [SerializeField]
    private float randomDirTimer = 2f;
    [SerializeField]
    private float minX = -10f;
    [SerializeField]
    private float maxX = 10f;
    private float currTimer = 0f;

    private void Update() {
            
        if (pebble.transform.position.y > 0.0f) {
            // move the computer player towards the pebble
            var difference = pebble.transform.position.x - transform.position.x;
            var distance = Mathf.Abs(difference);
            if(distance > tolerance)
            {
                // normalize the distance to use it as a speed factor
                var speedFactor = distance > 1f ? 1f : distance;

                direction = difference > 0 ? Vector3.right : Vector3.left;
                FlipPlayer(-difference);
                transform.position += direction * speedFactor * this.speed * Time.deltaTime;
            }

        }
        else {
            // move the computer player randomly
            currTimer += Time.deltaTime;
            if (currTimer >= randomDirTimer) {
                currTimer = 0f;
                float randomDir = Random.Range(-1, 1) > 0 ? 1 : -1;
                direction = new Vector3(randomDir, 0, 0);
                FlipPlayer(-randomDir);
            }
            // check if the player is out of bounds
            if(transform.position.x > maxX)
            {
                transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
                direction = Vector3.left;
                FlipPlayer(1);
            } else if (transform.position.x < minX)
            {
                transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                direction = Vector3.right;
                FlipPlayer(-1);
            }
            transform.position += direction * this.speed * Time.deltaTime;

        }

    }
     
}
    

