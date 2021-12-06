using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreVisual : MonoBehaviour
{
    [SerializeField] private HighScoreData highScoreData;
    [SerializeField] private Text[] textValue;
   



    public void ShowHighScore()
    {
        for (int i = 0; i < textValue.Length && i < highScoreData.HighScore.Count; i++)
            textValue[i].text = "" + highScoreData.HighScore[i];
    }
}
