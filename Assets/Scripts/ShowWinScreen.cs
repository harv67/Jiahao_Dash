using UnityEngine;

public class ShowWinScreen : MonoBehaviour
{
    [Tooltip("Drag the EndScreen Canvas (root GameObject) here")]
    public GameObject endScreen;

    [Tooltip("Tag used by the player GameObject (default: Player)")]
    public string playerTag = "Player";

    [Tooltip("Pause the game when the end screen appears")]
    public bool pauseGame = true;

    [Tooltip("Disable portal after it triggers to avoid double triggers")]
    public bool disableAfterTrigger = true;

    void Start()
    {
        // Make sure end screen is hidden at start (safe guard)
        if (endScreen != null) endScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // quick debug — remove or comment out in final build if you want
        Debug.Log($"[ShowWinScreen] Trigger entered by: {other.gameObject.name} (tag={other.gameObject.tag})");

        if (other.CompareTag(playerTag))
        {
            ShowEndScreen();
        }
    }

    void ShowEndScreen()
    {
        if (disableAfterTrigger) GetComponent<Collider2D>().enabled = false;

        if (endScreen == null)
        {
            Debug.LogWarning("[ShowWinScreen] endScreen not assigned in inspector!");
            return;
        }

        endScreen.SetActive(true);

        if (pauseGame) Time.timeScale = 0f;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        Debug.Log("[ShowWinScreen] End screen shown.");
    }
}