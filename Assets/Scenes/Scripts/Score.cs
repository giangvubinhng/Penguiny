using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   
    int score;
    public Text highScore;
   
    // Start is called before the first frame update

    void Start()
    {
        score = 0;
    }

    public void ScoreUp()
    {
        score++;
        GetComponent<Text>().text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
        
    }
    public void ShowHighScore()
    {
        highScore.gameObject.SetActive(true);
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore",score).ToString();  
    }
}
