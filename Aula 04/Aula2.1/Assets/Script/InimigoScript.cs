using UnityEngine;
using System.Collections;

public class InimigoScript : MonoBehaviour {

	public ArmaScript arma;

	void Awake() {
		arma = GetComponent<ArmaScript> ();
	}

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
		if (arma != null && arma.podeAtacar) {
			arma.atacar(true);
		}
	}
}
