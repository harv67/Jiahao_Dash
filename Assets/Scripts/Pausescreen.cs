using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseManager : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public GameObject pauseMenuUI; 
    private bool isPaused = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;         
        isPaused = true;
        backgroundMusic.Pause();
    }

 
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false); 
        Time.timeScale = 1f;         
        isPaused = false;
        backgroundMusic.UnPause();
    }

  
    public void ReplayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}