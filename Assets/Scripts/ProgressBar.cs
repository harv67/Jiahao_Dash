using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform player;
    public Transform levelEnd;
    public Slider progressBar;

    void Update()
    {
        float progress = player.position.x / levelEnd.position.x;
        progressBar.value = progress;
    }
}
