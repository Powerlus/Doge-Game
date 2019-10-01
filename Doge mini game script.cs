using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{

    private Vector2 targetPos;
    public float Yincrements;

    public float speed;
    public float maxHeight;
    public float minHeight;

    private void Update()
    {
        transform.posotion = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y > maxHeight) {
            targetPos = new Vector2(transform.posotopm.x, transform.position.y + Yincrement);
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yoncrememt);
            
        }
    }
}