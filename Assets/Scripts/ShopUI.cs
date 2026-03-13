using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ShopUI : MonoBehaviour
{
    public Button coinButton;
    public Button extraLifeButton;
    public Button jumpButton;
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CoinMultiplier()
    {
        ShopManager.Instance.BuyCoinMultiplier();
        coinButton.interactable = false; 
    }

    public void ExtraLife()
    {
        ShopManager.Instance.BuyExtraLife();
        extraLifeButton.interactable = false;
    }

    public void JumpBoost()
    {
        ShopManager.Instance.BuyJumpBoost();
        jumpButton.interactable = false;
    }

    private void Start()
    {
        coinButton.interactable = ShopManager.coinMultiplier == 0;
        extraLifeButton.interactable = ShopManager.extraLife == 0;
        jumpButton.interactable = ShopManager.jumpBoost == 0;
    }
}
