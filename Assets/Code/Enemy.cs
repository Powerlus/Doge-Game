using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int damage = 1;
    public Enemytime globalTime;
    
   

    void Update()
    {
        transform.Translate(Vector2.left * globalTime.timeenemy);
    }   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // player takes damage 
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}

