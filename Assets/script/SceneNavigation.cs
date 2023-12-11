using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    [Header("Class REference")]
    public GameManager gameManager;

    [Header("Game Object Reference")]
    public GameObject MC;
    public GameObject spawner;



    public void BtnStart()
    {
        gameManager.totalScore = 0;

        MC.transform.position = new Vector3(0, 0, 0);
        GameObject[] toDestroy = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach (GameObject go in toDestroy)
        {
            Destroy(go);
        }
    }

    public void BtnQuit()
    {
        Application.Quit();
    }

    public void restartBtn()
    {
        AsyncOperation reloadScene = SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;
    }
}
