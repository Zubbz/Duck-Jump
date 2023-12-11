using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [Header("Class Reference")]
    public GameManager gameManager;

    [Header("Panels")]
    public GameObject objUI;
    public GameObject gameOverPanel;

    [Header("GameElements")]
    public GameObject gameElements;
    public GameObject mcDuwcko;
    public GameObject spawner;



    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        objUI = GameObject.Find("UI").gameObject;
        gameOverPanel = objUI.transform.Find("GameOver").gameObject;

        gameElements = GameObject.Find("InGameElements").gameObject;
        mcDuwcko = gameElements.transform.Find("Duck").gameObject;
        spawner = gameElements.transform.Find("Obstacle Spawner").gameObject;

    }

    private void OnCollisionEnter2D(Collision2D actor)
    {
        gameOverPanel.gameObject.SetActive(true);
        mcDuwcko.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
        Time.timeScale = 0;

        if (gameManager.totalScore <= gameManager.highScore)
        {
            PlayerPrefs.SetInt("p_lastScore", gameManager.totalScore);
            PlayerPrefs.Save();
        }

        if (gameManager.totalScore > gameManager.highScore)
        {
            PlayerPrefs.SetInt("p_lastScore", gameManager.totalScore);
            PlayerPrefs.SetInt("p_highScore", gameManager.totalScore);
            PlayerPrefs.Save();
        }
    }
}
