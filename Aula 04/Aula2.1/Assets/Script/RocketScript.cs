using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	public int vida = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tratarTiro ();
	}

	void tratarTiro() {
		bool tiro = Input.GetButtonDown ("Fire1");
		tiro |= Input.GetButtonDown ("Fire2");

		if (tiro) {

			ArmaScript arma = GetComponent<ArmaScript>();

			if(arma != null) {
				// false pois nao sou o inimigo
				arma.atacar(false);
			}
		}
	}
}
