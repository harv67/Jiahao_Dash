using UnityEngine;

public class SpeedPortal : MonoBehaviour
{
    public float newSpeed = 100f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MapScrolling scroller = FindFirstObjectByType<MapScrolling>();

            if (scroller != null)
            {
                scroller.speed = newSpeed;
            }
        }
    }
}