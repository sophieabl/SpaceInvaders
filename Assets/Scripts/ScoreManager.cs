using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 

    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake(){
        instance = this; 
    }
    
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Shots: " + score.ToString() + "/60";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint() 
    {
        score += 1;
        scoreText.text = "Shots: " + score.ToString() + "/60";
        if (highscore > score){
            PlayerPrefs.SetInt("highscore", score);
        }
        if (score > 59){
           SceneManager.LoadScene("GameOver");
        }
        
    }
}
