using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void backToMainMenu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainMenu");
    }
}
