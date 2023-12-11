using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        speed = 5;
    }


    // Called before the first frame update
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;


    }

    void addSpeed()
    {
        speed = speed + 5;
    }
}
