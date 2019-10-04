using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {
   
    public GameObject enemy;

    void Start()
    {
       GameObject instance = Instantiate(enemy, transform.position, Quaternion.identity);
        instance.SetActive(true);
    }   
}