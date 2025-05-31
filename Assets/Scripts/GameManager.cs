using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TextMeshProUGUI scoreText;
    int score;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void ScoreUp()
    {
        score++;
    }

}
