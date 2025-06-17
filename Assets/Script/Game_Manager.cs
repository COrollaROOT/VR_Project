using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject startButton;

    private float timer = 0f;
    private bool isRunning = false;
    public float gameTime = 30f;

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
        startButton.SetActive(false);
    }
}
