using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static ShopManager Instance;

    [SerializeField] public static int jumpBoost = 0;
    [SerializeField] public static int extraLife = 0;
    [SerializeField] public static int coinMultiplier = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void BuyJumpBoost()
    {
        if (MoneyManager.Instance.TrySpend(20))
        {
            jumpBoost = 1;
        }
    }

    public void BuyExtraLife()
    {
        if (MoneyManager.Instance.TrySpend(30))
        {
            extraLife = 1;
        }
    }

    public void BuyCoinMultiplier()
    {
        if (MoneyManager.Instance.TrySpend(10))
        {
            coinMultiplier = 1;
        }
    }

}