using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigidBody;
	float xInput;
	public float moveSpeed;
	Vector2 nextPosition;

	public float xLimit;
	
	//x+ 2.6, x- -2.6
	private void Awake() {
		rigidBody = GetComponent<Rigidbody2D>();

	}
	private void FixedUpdate() {
		MovePlayer();
	}

	void MovePlayer(){
		xInput = Input.GetAxis("Horizontal");
		nextPosition = transform.position;
		nextPosition.x += xInput * moveSpeed;
		// transform.position = nextPosition;

		nextPosition.x = Mathf.Clamp(nextPosition.x, -xLimit, xLimit);
		rigidBody.MovePosition(nextPosition);
	}
}
