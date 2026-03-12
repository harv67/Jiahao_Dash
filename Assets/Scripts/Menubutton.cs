using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubutton : MonoBehaviour
{
    public void GoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}




