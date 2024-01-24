using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Player.position.z.ToString("0");
    }
}
