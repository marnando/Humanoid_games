using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//x = 0 - nao tem força
	//y = 300 - força 300
	//public faz com a veriavel se torne visivel no Unity para edicao
	public Vector2 forca = new Vector2(0, 300);

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		//clique do teclado
		if (Input.GetButtonDown("Jump"))
		{
			//Setando a velocidade do flappy para zero
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			//Aplico o vetor de forca no objeto flappy
			GetComponent<Rigidbody2D>().AddForce(forca);
		}
	}

	//Metodo chamado quando houver uma colisao
	void OnCollisionEnter2D(Collision2D collider) {
		//Verificando colisoes baseado na tag colocada nos filhos
		if (collider.gameObject.tag == "Colisor") 
		{
			//Debug.Log("Chamou");

			//Fica reiniciando o level sempre quando houver colisoes
			//Substituir por um menu
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
