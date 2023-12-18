using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TMP_Text scoreText1;
    public TMP_Text scoreText2;
    public static int score;
    public TMP_Text highScoreText;
    int highScore;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HS",0).ToString();
    }

    void Update()
    {
        scoreText1.text = "Score: " + score.ToString();
        scoreText2.text = "Score: " + score.ToString();

        if (score > PlayerPrefs.GetInt("HS", 0))
        {
            highScore = score;
            PlayerPrefs.SetInt("HS", highScore);
            highScoreText.text = PlayerPrefs.GetInt("HS", 0).ToString();
        }
    }

}
