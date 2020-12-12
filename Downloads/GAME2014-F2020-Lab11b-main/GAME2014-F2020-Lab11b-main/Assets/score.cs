using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public TextMeshProUGUI _score;
    int scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText = PlayerPrefs.GetInt("Score");
        _score.SetText(scoreText.ToString());

    }
}
