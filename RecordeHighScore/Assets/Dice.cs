using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Dice: MonoBehaviour
{
    public TextMeshProUGUI Score;
    public TextMeshProUGUI HighScore;

    public void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void RollDice()
    {
        int number = Random.Range(1, 7);
        Score.text = number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            HighScore.text = number.ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighScore.text = "0";
        Score.text = "0";
    }
}
