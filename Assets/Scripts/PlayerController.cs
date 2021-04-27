using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7.0f;
    public Rigidbody2D r2D;

    void Start () {

        if (r2D == null)
			r2D = GetComponent<Rigidbody2D>();
    }
  
    private void OnCollisionEnter2D (Collision2D collision) {

        ProcColl (collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        ProcColl (collision.gameObject);

    }

    void ProcColl (GameObject collider) {
        if (collider.CompareTag("Terrain")) {
            Jump();
        }
    }

    void Jump() {

        // Debug.Log("Jumped! " + "Velocity: " + r2D.velocity.y);

        if (r2D.velocity.y <= 0.5) {

            // Debug.Log("WIth sped: " + r2D.velocity.y);
            
            r2D.velocity = new Vector2 (0, speed);

        }

    }

}
