using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreOb : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        ScoreMain.instance.change += UpdateScoreUI;
    }

    private void UpdateScoreUI(int newScore)
    {
        scoreText.text = "Score: "+ newScore.ToString();
    }
}
