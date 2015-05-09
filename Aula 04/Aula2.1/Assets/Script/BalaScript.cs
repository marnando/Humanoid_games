using UnityEngine;
using System.Collections;

public class BalaScript : MonoBehaviour {

	public bool isEnemyShot = false;
	public int demage = 0;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Choque com a bala
	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
		Destroy (gameObject);
	}

	/*
	public bool isEnemyShot {
		get {
			return isEnemyShot;
		}

		set;
	}
	*/
}
