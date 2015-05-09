using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	//Objeto que sera instanciado dinamicamente
	public GameObject m_colisor;
	public float m_caneVelocityCreation;
	public int m_score;

	// Use this for initialization
	void Start () {
		//Metodo para criar os canos dinamicamente
		InvokeRepeating ("Create", 0, m_caneVelocityCreation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Instanciar o obejto prefab
	void Create () {
		Instantiate (m_colisor);
	}

	public void AddScore(int a_add) {
		m_score += a_add;
	}
}
