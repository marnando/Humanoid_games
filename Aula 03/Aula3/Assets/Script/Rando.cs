using UnityEngine;
using System.Collections;

public class Rando : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float f = Random.Range (-1, 3); // Random so da posiçao Y
		float height = Camera.main.orthographicSize; // OrthographicSize nao considera o Z
		float screenWidthInPonit = height * Camera.main.aspect; // Considera a camera. Calculo da lagura da camera

		// Trasforma a nova posiçao dos canos baseado no randomico 
		transform.position = new Vector3 (screenWidthInPonit, transform.position.y - f, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
