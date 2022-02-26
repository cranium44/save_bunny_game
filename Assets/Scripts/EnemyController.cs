using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float rotationSpeed;
	public GameObject dust;
	private void FixedUpdate() {
		transform.Rotate(0, 0, rotationSpeed);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(collision.gameObject);
		}else if(collision.gameObject.tag == "Ground"){
			GameObject _dust = Instantiate(dust, transform.position, Quaternion.identity);
			gameObject.SetActive(false);
			Destroy(_dust, 1f);
			Destroy(gameObject, 2f);
		}
	}
}
