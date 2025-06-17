using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public int score = 0;

    public void OnRingScored()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
