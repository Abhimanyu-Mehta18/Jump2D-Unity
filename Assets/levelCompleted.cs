using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCompleted : MonoBehaviour
{
    public GameObject next;
    public GameObject jump;
    public GameObject mainMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        next.SetActive(true);
        jump.SetActive(false);
        mainMenu.SetActive(true);
    }
}
