using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

	public Manager m_manager;
	public bool isScore;
	private bool isCollision = false;
	public float time = 0f;
	public float delay = 1f;
	public GameObject m_down;
	//public Transform m_down;

	// Use this for initialization
	void Start () {
		//Acessando o script Manager.cs capturando o elemento
		m_manager = GameObject.FindObjectOfType (typeof(Manager)) as Manager;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Criando uma linha em debug so para verificar
		//Posicao atual, posicao final, cor
		Debug.DrawLine (transform.position, m_down.transform.position, Color.red);
		//Debug.DrawLine (transform.position, m_down.position, Color.red);

		//Indentifica o layer entre as posicoes inicial e do objeto
		isScore = Physics2D.Linecast (transform.position, m_down.transform.position, 1 << LayerMask.NameToLayer ("Player"));

		if (isScore) 
		{
			if (!isCollision) 
			{
				Debug.Log("Colidiu!!" + isCollision);
				m_manager.AddScore(1);
				isCollision = true;
			}
		} else
		{
			Debug.Log("Colidiu!!" + isCollision);
			isCollision = false;
		}

		/*		} else
		{
			Debug.Log("Colidiu!!" + isCollision);
			isCollision = true;
		}
		if (time <= delay)
		{
			time += Time.deltaTime;
			m_manager.AddScore(1);
		}
	} else
	{
		time = 0;
*/

	}
}
