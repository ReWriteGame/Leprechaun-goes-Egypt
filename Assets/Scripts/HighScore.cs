using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    [SerializeField] private ScoreCounter score;
    [SerializeField] private HighScoreData highScoreData;
    [SerializeField] private int sizeHighScoreData;


    public void AddScore()
    {
        highScoreData.Add((int)score.Score);
        highScoreData.Sort();
        highScoreData.RemoveRange(sizeHighScoreData);
    }
}
