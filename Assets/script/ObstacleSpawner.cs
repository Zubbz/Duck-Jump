using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{


    [Header("Timers")]
    public float maxTime;
    public float timer;
    public float speed;

    [Header("Spawnable Objects")]
    public GameObject[] obstacles = new GameObject[0];

    void Start()
    {
        speed = 5;
        StartCoroutine(InitialStart());

        GameObject newObstacle = Instantiate(obstacles[0]);
        newObstacle.transform.position = transform.position + new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            int rnd = Random.Range(0, (obstacles.Length));
            GameObject newObstacle;
            newObstacle = Instantiate(obstacles[rnd]);
            newObstacle.transform.position = transform.position;
            Destroy(newObstacle, 10f);
            //maxTime -= maxTime * 0.01f;
            timer = 0;
        }
        timer += Time.deltaTime;

        GameObject[] obstacleMove = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach (GameObject obObj in obstacleMove)
        {
            obObj.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    IEnumerator objSpeedIncrease()
    {
        while (true)
        {
            speed = speed + 5;
            maxTime = maxTime - 0.5f;

            yield return new WaitForSeconds(15f);
        }
    }

    IEnumerator InitialStart()
    {
        yield return new WaitForSeconds(15f);
        StartCoroutine(objSpeedIncrease());
    }
}