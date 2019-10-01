﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int damage = 1;
    public float speed;
    public int health;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    
        if (health<- 0)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // player takes damage 
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);

            if (other.CompareTag("Player"))
            {
                // player takes damage 
                other.GetComponent<Enemy>().health -= damage;
                Destroy(gameObject);
            }
            
        }
    }
