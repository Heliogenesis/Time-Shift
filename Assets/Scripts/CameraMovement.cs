using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float MovementSpeed = 2; 


    private GameObject player;
    Vector3 playerScreenPosition;

    private void Awake()
    {
        player = GameObject.Find("Game Player");
        transform.position = player.transform.position;
        transform.position += new Vector3(0, 0, -10);
    }

    void Update ()
    {
        playerScreenPosition = Camera.main.WorldToScreenPoint(player.transform.position);
        if (playerScreenPosition.x >=  1920 * .8)
        {
            transform.position += Vector3.right * MovementSpeed * Time.deltaTime;             
        }
        if (playerScreenPosition.x <= 1920 * .2)
        {
            transform.position += Vector3.left * MovementSpeed * Time.deltaTime;
        }
        if (playerScreenPosition.y >= 1080 * .8)
        {
            transform.position += Vector3.up * MovementSpeed * Time.deltaTime;
        }
        if (playerScreenPosition.y <= 1080 * .2)
        {
            transform.position += Vector3.down * MovementSpeed * Time.deltaTime * 2;
        }
    }
}
