using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : Score
{
    public override void UpdateScore(int value)
    {
        score += value;
        ScoreManager.instance.IncrementScore(score);
    }
}
