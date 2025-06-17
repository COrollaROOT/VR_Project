using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FINGameManager : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text timerText;
    public TMP_Text scoreText;
    public GameObject startButton;
    public GameObject restartButton;

    [Header("Game Time")]
    public float gameTime = 30f;
    private float timer = 0f;
    private bool isRunning = false;

    [Header("Score")]
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
        restartButton.SetActive(false);
    }

    void Update()
    {
        if (isRunning)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isRunning = false;
                timerText.text = "Time Over!";
                restartButton.SetActive(true); // Ÿ�� ���� �� ��ư ǥ��
            }
            else
            {
                timerText.text = "Time: " + timer.ToString("F2");
            }
        }
    }

    public void StartGame()
    {
        timer = gameTime;
        isRunning = true;
        score = 0;

        UpdateScoreText();
        timerText.text = "Time: " + timer.ToString("F2");

        startButton.SetActive(false);
        restartButton.SetActive(false);
    }

    public void RestartGame()
    {
        StartGame(); // ������ �ʱ�ȭ ���� ����
    }

    public void OnRingScored()
    {
        score++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
