using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_position : MonoBehaviour
{
    public GameObject player;
    public Vector3 movement;

    public void FixedUpdate()
    {
        transform.position = player.transform.position + movement;
    }
}
