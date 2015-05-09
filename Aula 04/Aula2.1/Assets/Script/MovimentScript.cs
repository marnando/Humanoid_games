using UnityEngine;
using System.Collections;

public class MovimentScript : MonoBehaviour {

	//Joel
	public Vector2 speedJoel = new Vector2(10, 10);
	public Vector2 direction = new Vector2(-1, 0);
	public Vector2 movement;

	//public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10); //time in seconds
	}
	
	// Update is called once per frame
	void Update () {

		//Joel
		movement = new Vector2(speedJoel.x * direction.x, speedJoel.y * direction.y);
		//GetComponent<Rigidbody2D> ().velocity = (-Vector2.right) * speed;
	}

	void FixedUpdate() {
		//Joel
		GetComponent<Rigidbody2D> ().velocity = movement;
	}
}
