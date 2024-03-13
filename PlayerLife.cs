using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // You need to add this for scene management.

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 initialPosition;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position; // Store the initial position of the player.
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        // You can reload the current scene to respawn the player at the beginning.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        // Or you can reset the player's position to the initial position.
        // transform.position = initialPosition;

        // Reset the rigidbody properties if needed.
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
    }
}
