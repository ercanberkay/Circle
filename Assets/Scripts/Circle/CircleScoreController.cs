using TMPro;
using UnityEngine;

public class CircleScoreController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    int score = 0;

    public void IncreaseScoreValue()
    {
        score++;
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = score.ToString();
    }
}
