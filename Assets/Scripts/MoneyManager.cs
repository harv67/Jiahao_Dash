using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;

    [Header("Money")]
    [SerializeField] private int Coin = 0;

    [Header("UI")]
    [SerializeField] private TMP_Text CoinDisplay;

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
        RefreshUI();
    }

    public bool TrySpend(int amount)
    {
        if (Coin < amount) 
        {
            return false;
        }

        Coin -= amount;
        RefreshUI();
        return true;
    }

    public void RefreshUI()
    {
        CoinDisplay.text = $"{Coin}";
    }
}