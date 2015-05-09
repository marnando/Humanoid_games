using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public Manager m_manager;

	// Use this for initialization
	void Start () {
		//Acessando o script Manager.cs capturando o elemento
		m_manager = GameObject.FindObjectOfType (typeof(Manager)) as Manager;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.color = Color.black;
		GUILayout.Label ("Score: " + m_manager.m_score);
	}
}
