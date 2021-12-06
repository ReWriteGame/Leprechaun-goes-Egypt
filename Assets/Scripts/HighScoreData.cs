using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "HighScoreData", menuName = "ScriptableObjects/HighScoreData", order = 1)]
public class HighScoreData : ScriptableObject
{
    [SerializeField] private List<int> highScore;

    public List<int> HighScore { get => highScore; private set => highScore = value; }

    public void Sort()
    {
        highScore.Sort();
    }

    public void Add(int value)
    {
        highScore.Add(value);
    }

    public void RemoveRange(int index)
    {
        highScore.RemoveRange(0, index);
    }
}
