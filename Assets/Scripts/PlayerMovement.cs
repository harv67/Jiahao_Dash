using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isLanded = true;
    [SerializeField] float jumpForce = 5f;


    void Start()
    {
        
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
        //how tf do u flip
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            isLanded = true;
        }
    }
}
