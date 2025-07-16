using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject restart;
    public GameObject jump;
    public GameObject mainMenu;
    public AudioSource src;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstical")
        {
            src.Play();
            Debug.Log("dead");
            restart.SetActive(true);
            mainMenu.SetActive(true);
            jump.SetActive(false);
            GetComponent<move>().enabled = false;
        }
    }
}
