using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    [SerializeField]public bool isPaused = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    void ResumeGame()
    {
        Debug.Log("Resume button clicked.");    
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
    }

    public void ResumeButtonClicked()
    {
        ResumeGame();
    }

}
