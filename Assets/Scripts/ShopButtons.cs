using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    void Start()
    {
        MoneyManager.Instance.RefreshUI();
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}