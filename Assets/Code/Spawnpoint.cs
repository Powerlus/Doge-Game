using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {
   
    public GameObject enemy;
    
    void Start()
    {
       Instantiate(enemy, transform.position, Quaternion.identity);
    }

   


}