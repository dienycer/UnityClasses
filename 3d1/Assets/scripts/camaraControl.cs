using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraControl : MonoBehaviour {
	public GameObject ball;
	private Vector3 diff;
	private isRotating;
	// Use this for initialization
	void Start () {
		isRotating = 0;

		//diff tiene que tener la diferencia de posiciones
		//entre el GameObject camara y el GameObject que persigo
		this.diff = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = ball.transform.position + this.diff;
		if(inPut.GetKeyDown("r")){
			Vector3 rotation = new Vector3 (0.0f, 3.0f, 0.0f);
			transform.Rotate ()
		}
	}
}
