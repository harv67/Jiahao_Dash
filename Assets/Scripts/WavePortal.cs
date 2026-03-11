using UnityEngine;

public class PortalToWave : MonoBehaviour
{
    [Header("Wave GameObject in Scene")]
    public GameObject waveObject; // your wave

    [Header("Player Components")]
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;
    public Rigidbody2D playerRigidbody;
    public MonoBehaviour[] playerScripts; // all scripts controlling player behavior

    [Header("Wave Components")]
    public MonoBehaviour[] waveScripts; // scripts that control the wave
    public Collider2D waveCollider;
    public Rigidbody2D waveRigidbody;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // --- Disable original player ---
            if (playerSprite != null) playerSprite.enabled = false;
            if (playerCollider != null) playerCollider.enabled = false;
            if (playerRigidbody != null)
            {
                playerRigidbody.linearVelocity = Vector2.zero;
                playerRigidbody.simulated = false;
            }
            foreach (MonoBehaviour script in playerScripts)
                script.enabled = false;

            // --- Enable wave ---
            waveObject.SetActive(true);
            waveObject.transform.position = other.transform.position;

            if (waveRigidbody != null)
            {
                waveRigidbody.simulated = true;
                waveRigidbody.linearVelocity = Vector2.zero;
            }
            if (waveCollider != null) waveCollider.enabled = true;
            foreach (MonoBehaviour script in waveScripts)
                script.enabled = true;
        }
    }
}