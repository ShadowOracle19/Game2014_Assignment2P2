using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour
{
    public int remaining = 10;
    public int scoreText = 0;
    public TextMeshProUGUI heartText;
    public TextMeshProUGUI score;
    public void CollectedHeart()
    {
        remaining -= 1;
        Debug.Log(remaining);
    }
    public void addScore(int score)
    {
        scoreText += score;
        PlayerPrefs.SetInt("Score", scoreText);
    }
    void Update()
    {
        heartText.SetText(remaining.ToString());
        score.SetText(scoreText.ToString());
        if(remaining <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
