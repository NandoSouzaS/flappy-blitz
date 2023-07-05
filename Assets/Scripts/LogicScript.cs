using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public int multiplier = 1;
    public GameObject gameOverScreen;

    [ContextMenu("increase socre")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd * multiplier;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
