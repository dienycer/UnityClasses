﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private int isJumping;
	private int numMaxSaltos;

	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody>();
		isJumping = 0;
		numMaxSaltos = 1;
	
	}
	

	void FixedUpdate () {
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		rb.AddForce(movement*speed);

		if (Input.GetKeyDown("space")&& numMaxSaltos > 0){
			Vector3 jumpForce = new Vector3 (0.0f, 5.0f, 0.0f);
			rb.AddForce(jumpForce, ForceMode.Impulse);
			numMaxSaltos--;
		}
			
}
	void OnCollisionEnter(Collision c){
		this.numMaxSaltos = 1;
	}
}