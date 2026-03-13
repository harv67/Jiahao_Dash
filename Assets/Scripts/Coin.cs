using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int value = 1;
            if (ShopManager.coinMultiplier > 0)
            {
                value = 3;
            }
            MoneyManager.Instance.GainMoney(value);
            Destroy(gameObject);
        }
    }
}
