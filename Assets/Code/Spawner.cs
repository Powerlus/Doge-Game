using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] EnemyPattern;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, EnemyPattern.Length);
            GameObject pattern = EnemyPattern[rand];
            GameObject spawnedStuff = Instantiate(pattern, transform.position, Quaternion.identity);
            spawnedStuff.SetActive(true);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
                startTimeBtwSpawn -= decreaseTime;

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

    }
}