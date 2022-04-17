using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int _currentScore = 0;
    private int _highScore = 0;
    private int _scoreCounter = 100;
    public static ScoreManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (GameManager.instance.isGameStart)
        {
            ScoreCounter();
            UIManager.instance.ScoreUpdate(_currentScore);
        }
    }

    public void ScoreCounter()
    {
        _currentScore += (int)(Time.deltaTime * _scoreCounter);
    }
}
