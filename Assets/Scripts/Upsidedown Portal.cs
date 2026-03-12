using UnityEngine;

public class UpsideDownGravityPortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                // Force upside-down gravity
                rb.gravityScale = -Mathf.Abs(rb.gravityScale);

                // Reset vertical velocity
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            }

            // Flip the player visually
            Vector3 scale = other.transform.localScale;
            scale.y = -Mathf.Abs(scale.y);
            other.transform.localScale = scale;
        }
    }
}