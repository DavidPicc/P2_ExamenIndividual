using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void IncrementScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
