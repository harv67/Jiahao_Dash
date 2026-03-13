using UnityEngine;

public class VictoryPortal : MonoBehaviour
{
    [SerializeField] private WinScreen winManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winManager.ShowVictory();
            Debug.Log("Level Complete!");
            ShopManager.jumpBoost = 0;
            ShopManager.extraLife = 0;
            ShopManager.coinMultiplier = 0;

        }
    }
}
