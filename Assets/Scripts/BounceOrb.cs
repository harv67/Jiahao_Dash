using UnityEngine;

public class BounceOrb : MonoBehaviour
{
    public float bounceForce = 12f;

    private bool playerInside = false;
    private Rigidbody2D playerRb;

    void Update()
    {
        if (playerInside && Input.GetKey(KeyCode.Space)) // click or tap
        {
            if (playerRb != null)
            {
                playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, bounceForce);
            }

            playerInside = false; // prevents repeated bouncing
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            playerRb = other.GetComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
}