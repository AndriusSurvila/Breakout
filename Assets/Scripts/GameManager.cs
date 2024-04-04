using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 0;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    private void Update()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            enabled = false;
        }

        if (FindObjectsOfType<Brick>().Length < 1)
        {
            winScreen.SetActive(true);
            enabled = false;
        }
    }
}
