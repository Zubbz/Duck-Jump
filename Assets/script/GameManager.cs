using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    [Header("Initial Value")]
    public int totalScore;
    public int lastScore;
    public int highScore;

    [Header("InGame panel")]
    public TextMeshProUGUI txtScore;

    [Header("GameOver panel")]
    public TextMeshProUGUI txtLastScore;
    public TextMeshProUGUI txtHIghScore;


    void Update()
    {
        highScore = PlayerPrefs.GetInt("p_highScore");

        txtScore.text = totalScore.ToString();
        txtHIghScore.text = highScore.ToString();
        lastScore = PlayerPrefs.GetInt("p_lastScore");
        txtLastScore.text = lastScore.ToString();
    }
}
