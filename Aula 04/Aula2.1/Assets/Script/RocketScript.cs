using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	public int vida = 10;
    public float delayTime = 0.5f;

    public Animator animation;

	// Use this for initialization
	void Start () {
        animation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		tratarTiro ();
	}

	void tratarTiro() {
		//bool tiro = Input.GetButtonDown ("Fire1");
		//tiro |= Input.GetButtonDown ("Fire2");

		if (ControllerScript.isFire) {

			ArmaScript arma = GetComponent<ArmaScript>();

			if(arma != null) {
				// false pois nao sou o inimigo
				arma.atacar(false);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
        //animation.SetBool("explode", true);
        //yield return new WaitForSeconds(delayTime);
		
		if (coll.gameObject.tag != "Barra_up" 
		||  coll.gameObject.tag != "Barra_down")
		{
			Destroy (gameObject);
			Destroy (coll.gameObject); //Se o 'outro' for um item por exemplo deve ser tratado diferente
			ManageGameScript.IS_GAME_OVER = true;
		}
	}
}
