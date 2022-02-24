using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	RigidBody2D rigidBody;
	float xInput;
	public float moveSpeed;
	Vector2 nextPosition;

	private void Awake() {
		rigidBody = GetComponent<RigidBody2D>();

	}
	private void FixedUpdate() {
		MovePlayer();
	}

	void MovePlayer(){
		xInput = Input.GetAxis("Horizontal");
	}
}
