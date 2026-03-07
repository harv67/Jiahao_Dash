using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("you are dead");
        }
    }
}
