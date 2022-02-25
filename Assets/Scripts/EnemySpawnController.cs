using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour {

	public GameObject enemy;
	public float xLimit;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate() {
		
	}

	void SpawnEnemy(){
		float randomX = Random.Range(-xLimit, xLimit);
		Vector2 spawnPoint = new Vector2(randomX, transform.position.y);
		Instantiate(enemy, spawnPoint, Quaternion.identity);
	}
}
