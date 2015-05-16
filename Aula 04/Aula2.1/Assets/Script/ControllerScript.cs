using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public Transform playerTransform;
	public RocketScript rock;

	//Velocidade da nave
	public Vector2 speed = new Vector2(10, 10);
	public Vector2 movement;

	//Movement flags
	public bool moveRight, moveLeft, moveUp, moveDown = false;

	public static bool isFire = false;

	void Awake() {
		//Capturando o Script RocketScript
		rock = playerTransform.gameObject.GetComponent<RocketScript>();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		calculaMoviment ();
	}

	void FixedUpdate() {
		if (moveUp
		||  moveDown
		||  moveRight
		||  moveLeft) 
		{
			ApplyMovement();
		}
	}

	public void calculaMoviment() {

		float directionMoveX = 0.0f;
		float directionMoveY = 0.0f;

		//definindo a escala de movimentacao por direcao
		if (moveRight) 
		{
			directionMoveX = 150.25f;
		} else 
		if (moveLeft) 
		{
			directionMoveX = -100.25f;
		} else 
		if (moveUp) 
		{
			directionMoveY = 150.25f;
		} else 
		if (moveDown)
		{
			directionMoveY = -100.25f;
		}

		//Aplicando o movimento
		float x = speed.x * (directionMoveX * Time.deltaTime);
		float y = speed.y * (directionMoveY * Time.deltaTime);
		movement = new Vector2 (x, y);
	}

	public void ApplyMovement() {
		rock.GetComponent<Rigidbody2D> ().velocity = movement;
	}

	public void Up() {
		moveUp = true;
	}

	public void Down() {
		moveDown = true;
	}

	public void Left() {
		moveLeft = true;
	}

	public void Right() {
		moveRight = true;
	}

	public void Fire() {
		isFire = true;
	}

	public void StopFire() {
		isFire = false;
	}
	
	public void removeMovement() {
		moveUp = false;
		moveDown = false;
		moveRight = false;
		moveLeft = false;

		rock.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
	}

}
