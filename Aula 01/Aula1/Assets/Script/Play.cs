using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public Vector2 speed = new Vector2(10, 10);
	public Vector2 movement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Axis information
		float inputX = Input.GetAxis ("Horizontal"); //keys action
		float inputY = Input.GetAxis ("Vertical");

		//Movement direction
		movement = new Vector2 (speed.x * inputX, speed.y * inputY);
	}

	//Phisics components
	void FixedUpdate() {
		//Catch component from Unity
		GetComponent<Rigidbody2D> ().velocity = movement;
	}
}
