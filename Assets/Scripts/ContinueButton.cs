using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Button continueButton;

    private bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);

        continueButton.onClick.AddListener(Resume);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
            
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;

        pauseMenuUI.SetActive(true);
    }

    void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;

        pauseMenuUI.SetActive(false);
    }
}
