﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float Yincrements;

    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health;
    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrements);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrements);

        }

    }
}