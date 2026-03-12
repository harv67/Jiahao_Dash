using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
        Time.timeScale = 1f;
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("ShopScene");
    }
}
