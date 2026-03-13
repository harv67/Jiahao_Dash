using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeDamage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (ShopManager.extraLife > 0)
            {
                ShopManager.extraLife --;
                Debug.Log("u got one more chance");
                return;
            }
            Debug.Log("you are dead");
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            ShopManager.jumpBoost = 0;
            ShopManager.extraLife = 0;
            ShopManager.coinMultiplier = 0;
        }
    }
}