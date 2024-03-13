using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource; // Reference to the AudioSource component.

    // Attach your background music audio clip to this field in the Unity editor.
    public AudioClip backgroundMusic;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Get the AudioSource component attached to this GameObject.
        audioSource = GetComponent<AudioSource>();

        // Set the AudioClip for the AudioSource.
        audioSource.clip = backgroundMusic;

        // Play the background music.
        audioSource.Play();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 18f);
        }
    }
}
