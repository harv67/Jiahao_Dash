using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isLanded = true;
    [SerializeField] public float jumpForce = 5f;


    void Start()
    {
        if (ShopManager.jumpBoost > 0)
        {
            jumpForce += 15f;
        }
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isLanded)
        {
            Jump();
            isLanded = false;
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        // rotation if possible if not its okay
        float direction = Mathf.Sign(rb.gravityScale);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce * direction);      
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            isLanded = true;
        }
    }
}
