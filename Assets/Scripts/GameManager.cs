using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }
    bool isGameOver = false;
	int score = 0;
	public Text scoreText;
	public GameObject gameOverPanel;

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
		ResetScore();
		gameOverPanel.SetActive(true);
        GameObject.Find("EnemySpawnPoint").GetComponent<EnemySpawnController>().StopSpawn();
    }

	public void UpdateScore(){
		if(!isGameOver){
			score += 1;
			scoreText.text = score.ToString();
		}
	}

	void ResetScore(){
		score = 0;
	}
}
