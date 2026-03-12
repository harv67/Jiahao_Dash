using UnityEngine;

public class DefaultSpeedPortal : MonoBehaviour
{
    public float returnSpeed = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MapScrolling scroller = FindFirstObjectByType<MapScrolling>();

            if (scroller != null)
            {
                scroller.speed = returnSpeed;
            }
        }
    }
}