using UnityEngine;

public class Enemytime : MonoBehaviour
{
    
    public float timeenemy;
    public float max;
    public float increase;
    // Update is called once per 1 frame
    void Update()
    {
        if (timeenemy < max)
        {
            timeenemy += increase * Time.deltaTime;
        }
        else if (timeenemy > max) {
            timeenemy = max;
        }

    }
}