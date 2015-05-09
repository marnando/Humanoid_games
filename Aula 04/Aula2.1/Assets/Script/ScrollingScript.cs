using UnityEngine;
using System.Collections;

public class ScrollingScript : MonoBehaviour {

	//speed
	public Vector2 speed = new Vector2(2, 2);

	// moving direction
	public Vector2 direction = new Vector2(-1, 0);

	public GameObject bg;

	//Screen position
	Vector3 screenPos;

	//Lagura da camera de acordo com o aspect ratio
	float width;

	//pega a posicao inicial do background para retpeti-lo no final
	float Y;

	// Use this for initialization
	void Start () {
		float height = 2f * Camera.main.orthographicSize;
		width = height * Camera.main.aspect;

		Y = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		moveParallax ();
	}

	// realiza o movimento dos ambientes: background e etc
	private void moveParallax() {
		Vector3 movement = new Vector3 (speed.x * direction.x, speed.y * direction.y, 0f);

		movement *= Time.deltaTime;
		transform.Translate (movement);

		screenPos = Camera.main.WorldToScreenPoint (bg.transform.position);

		if (screenPos.x < -Screen.width * 0.5f) {
			Debug.Log("Entrou no laço ====== entrou no laço ===== entrou no laço");
			gameObject.transform.position = new Vector3(width, Y, 0f);
		}
	}
}
