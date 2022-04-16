using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _high_scoreText;
    [SerializeField] private float scoreMultiple = 1f;
    private float _currentScore = 0;
    private float _highScore = 0;
    private void Update()
    {
        if (GameManager.instance.isGameStart)
        {
            _currentScore += (int)(Time.deltaTime * scoreMultiple);
            _scoreText.text = "Score: " + _currentScore.ToString();
        }
        else if (!GameManager.instance.isGameStart)
        {
            if (_currentScore > _highScore)
            {
                _highScore = _currentScore;
                _high_scoreText.text = "Highscore: " + _highScore.ToString();
            }
        }
    }
}
