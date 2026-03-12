using UnityEngine;

public class UFOPortal : MonoBehaviour
{
    [Header("UFO GameObject in Scene")]
    public GameObject UFOObject; // your ufo

    [Header("Player Components")]
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;
    public Rigidbody2D playerRigidbody;
    public MonoBehaviour[] playerScripts; // all scripts controlling player behavior

    [Header("UFO Components")]
    public MonoBehaviour[] UFOScripts; // scripts that control the ufo
    public Collider2D UFOCollider;
    public Rigidbody2D UFORigidbody;

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

            // --- Enable ufo ---
            UFOObject.SetActive(true);
            UFOObject.transform.position = other.transform.position;

            FindFirstObjectByType<TriggerCam>().SetTarget(UFOObject.transform);

            if (UFORigidbody != null)
            {
                UFORigidbody.simulated = true;
                UFORigidbody.linearVelocity = Vector2.zero;
            }
            if (UFOCollider != null) UFOCollider.enabled = true;
            foreach (MonoBehaviour script in UFOScripts)
                script.enabled = true;
        }
    }
}