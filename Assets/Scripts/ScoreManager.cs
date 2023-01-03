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
    public TMP_Text alienCounter;

    int score = 0;
    int highscore = 60;
    int aliens = 0; 

    private void Awake(){
        instance = this; 
    }
    
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 60);
        scoreText.text = "Shots: " + score.ToString() + "/60";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        alienCounter.text = aliens.ToString() + " / 27";
    }
 
    // Function that adds a point when shoting a bullet 
    public void AddPoint() 
    {
        score += 1;
        scoreText.text = "Shots: " + score.ToString() + "/60";
        // if your need less bullets that before, score will be new highscore 
        if (aliens >= 27 && score < highscore){
            PlayerPrefs.SetInt("highscore", score);
        }
        // If bullet limit is reached GameOver screen appears 
        if (score > 59){
           SceneManager.LoadScene("GameOver");
        }
        
    }

    // Function that counts the aliens that have been shot 
    public void AlienShot()
    {
          aliens += 1; 
          alienCounter.text = aliens.ToString() + " / 27";
          // If all aliens are destroyed GameOver 
          if (aliens > 26)
          {
            SceneManager.LoadScene("GameOver");
          }
    }
}
