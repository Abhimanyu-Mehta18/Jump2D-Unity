using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public Button pauseBtn;
    public GameObject pauseMenuUI;

    void Update()
    {
        pauseBtn.onClick.AddListener(() =>
        {
            if (isPaused)
            {
                resume();
            }
            else {
                Paused();
            }
        });
    }
    public void resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
