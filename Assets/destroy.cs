using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void Update()
    {
        if (GameObject.Find("player").transform.position.x > transform.position.x + 2f)
        {
            Destroy(this.gameObject);
        }
    }
}
