using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    [Header("Class Reference")]
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    private void OnTriggerEnter2D(Collider2D actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            gameManager.totalScore += 1;
        }
    }

}
