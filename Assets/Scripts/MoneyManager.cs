using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;

    [Header("Money")]
    [SerializeField] public int Coin = 0;

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

    public void GainMoney()
    {
        Coin += 1;
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
}