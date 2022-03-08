using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }
    bool isGameOver = false;
    int score = 0;
    public Text scoreText;
    public GameObject gameOverPanel;
    public Text finalScoreText;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Use this for initialization

    public void GameOver()
    {
        isGameOver = true;
        GameObject.Find("EnemySpawnPoint").GetComponent<EnemySpawnController>().StopSpawn();
        finalScoreText.text = "Score: " + score.ToString();
        gameOverPanel.SetActive(true);
    }

    public void UpdateScore()
    {
        if (!isGameOver)
        {
            score += 1;
            scoreText.text = score.ToString();
        }
    }

    void ResetScore()
    {
        score = 0;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
