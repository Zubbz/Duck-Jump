using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public ObstacleScript obstacle;
    public float maxTime = 1;
    private float timer = 0;
    public float height = -2;

    void Start()
    {

        //Instantiate(obstacle);

    }

    void Update()
    {
        if (timer > maxTime)
        {
            ObstacleScript gameObstacle = Instantiate(obstacle);
            gameObstacle.transform.position = transform.position + new Vector3(0, -2.5f, 0);
            Destroy(gameObstacle, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
