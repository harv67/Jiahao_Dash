using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;

    [Header("Money")]
    [SerializeField] private int Coin = 0;

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

    public void GainMoney(int amount = 1)
    {
        Coin += amount;
    }

    public bool TrySpend(int amount)
    {
        if (Coin < amount) 
        {
            return false;
        }

        Coin -= amount;
        return true;
    }

    public int GetCoin()
    {
        return this.Coin;
    }
}