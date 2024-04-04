using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lives = 0;
    public static int score = 0;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    public AudioClip winSound;
    public AudioClip loseSound;

    private void Update()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            AudioSystem.Play(loseSound);
            enabled = false;
        }

        if (FindObjectsOfType<Brick>().Length < 1)
        {
            winScreen.SetActive(true);
            AudioSystem.Play(winSound);
            enabled = false;
        }
    }
}
