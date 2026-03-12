using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    void Start()
    {
    
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}