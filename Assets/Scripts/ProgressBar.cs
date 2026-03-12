using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform player;
    public Slider progressBar;
    private float maxDistanceReached = 1f;

    void Update()
    {
        if (player == null || progressBar == null) return;

        // Update the max distance if player goes further
        if (player.position.x > maxDistanceReached)
        {
            maxDistanceReached = player.position.x;
        }

        float progress = Mathf.Clamp01(player.position.x / maxDistanceReached);
        progressBar.value = progress;
    }
}
