using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField] float waveSpeed = 8f;

    float direction = -1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.freezeRotation = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = 1f;
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = -1f;
            transform.rotation = Quaternion.Euler(0, 0, -45);
        }

        rb.linearVelocity = new Vector2(0, direction * waveSpeed);
    }
}