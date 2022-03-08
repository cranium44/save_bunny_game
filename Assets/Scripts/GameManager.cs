using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }
    bool isGameOver = false;
	int score = 0;

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
        GameObject.Find("EnemySpawnPoint").GetComponent<EnemySpawnController>().StopSpawn();
    }

	public void UpdateScore(){
		if(!isGameOver){
			score += 1;
		}
	}

	void ResetScore(){
		score = 0;
	}
}
