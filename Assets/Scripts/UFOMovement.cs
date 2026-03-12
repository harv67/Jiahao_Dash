using UnityEngine;

public class UFOMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float jumpForce = 8f;


    void Start()
    {
        rb.freezeRotation = true;
        rb.gravityScale = 3;

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
      
    }
}
