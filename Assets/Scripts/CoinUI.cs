using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] TMP_Text coinText;

    void Update()
    {
        coinText.text = MoneyManager.Instance.Coin.ToString();
    }
}
