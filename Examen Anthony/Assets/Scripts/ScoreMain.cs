using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ScoreMain : MonoBehaviour
{
    public static ScoreMain instance;
    public int score;
    public event Action<int> change;

    public int Score
    {
        get
        {
            return score;
        }
        private set
        {
            score = value;
            change?.Invoke(score);
        }
    }

    private void Awake()
    {
        instance = this;
    }

    public void Increment (int amount)
    {
        Score += amount;
    }
}
