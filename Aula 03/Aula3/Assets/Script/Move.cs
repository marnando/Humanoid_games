using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	//Movimento no eixo X, e sera ramdomico no eixo Y
	//Movimento sera da direita para a esquerda
	public Vector2 velocidade = new Vector2(-1, 0);

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = velocidade;
		Invoke ("Destruir", 10f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Destruir() {
		Destroy (gameObject);
	}
}
