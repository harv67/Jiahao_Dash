using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject winUI; 

    public void ShowWinScreen()
    {
        winUI.SetActive(true); 
        Time.timeScale = 0f;    
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;    
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Debug.Log("Quit button pressed!");
    }
    public void ShowVictory()
    {
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
