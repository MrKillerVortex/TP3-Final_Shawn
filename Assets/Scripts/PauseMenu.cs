using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject audioMenu;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        audioMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            } else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void LoadAudioMenu()
    {
        Time.timeScale = 1f;
        audioMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Accueil");
    }
}
