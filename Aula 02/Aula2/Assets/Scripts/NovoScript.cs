using UnityEngine;
using System.Collections;

//Demonstraçao ciclo de vida
public class NovoScript : MonoBehaviour {

	//Recomendado ao inves do construtor. Essa funçao e executada antes do Start()
	void Awake () {
		Debug.Log ("Awake!");
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("Start!");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update!");
	}

	void FixedUpdate () {
		Debug.Log ("FixedUpdate!");
	}

	//Componentes de tela e entrada de dados: mouse, teclado, etc, criaçao de botoes, janelas e etc
	void OnGUI () {
		Debug.Log ("On GUI!");

		if (GUI.Button(new Rect (20, 40, 80, 20), "Iniciar")) {
		}
	}
}
