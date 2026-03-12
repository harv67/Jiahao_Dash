using UnityEngine;

public class CubePortal : MonoBehaviour
{
    [Header("UFO GameObject in Scene")]
    public GameObject UFOObject;

    [Header("Player Components")]
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;
    public Rigidbody2D playerRigidbody;
    public MonoBehaviour[] playerScripts;

    [Header("UFO Components")]
    public MonoBehaviour[] UFOScripts;
    public Collider2D UFOCollider;
    public Rigidbody2D UFORigidbody;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // --- Disable UFO ---
            if (UFOCollider != null) UFOCollider.enabled = false;

            if (UFORigidbody != null)
            {
                UFORigidbody.linearVelocity = Vector2.zero;
                UFORigidbody.simulated = false;
            }

            foreach (MonoBehaviour script in UFOScripts)
                script.enabled = false;

            UFOObject.SetActive(false);

            // --- Enable Player ---
            if (playerSprite != null) playerSprite.enabled = true;
            if (playerCollider != null) playerCollider.enabled = true;

            if (playerRigidbody != null)
            {
                playerRigidbody.simulated = true;
                playerRigidbody.linearVelocity = Vector2.zero;
            }

            foreach (MonoBehaviour script in playerScripts)
                script.enabled = true;

            FindFirstObjectByType<TriggerCam>().SetTarget(playerRigidbody.transform);
        }
    }
}