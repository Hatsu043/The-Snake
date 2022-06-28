using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Text scoreText;  //Score text
    private int score;  //Score value
    public string sceneName;

    public void ResetScore()  //Reset score
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void IncreaseScore()  //Increase score
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ChangeStage() //Change stage when score = 10
    {
        if(score == 10)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
