using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManageGameScript : MonoBehaviour {

	//Criar inimigos aleatorios
	public Transform inimigoPrefab;
	float camHalfWidth;
	float width;
	float height;

	public Text score;
	public int highScore;
	string highScoreKey = "HighScore";

	public static bool IS_GAME_OVER = false;
	public static int SCORE_COUNT = 0;

	// Use this for initialization
	void Start () {
		//atura e largura da tela
		height = 2f * Camera.main.orthographicSize;
		width = height * Camera.main.aspect;

		criaInimigo ();
		//Chave PlayerPrefs e proprietario do Unity, serve como banco, estudar mais sobre o assunto
		highScore = PlayerPrefs.GetInt (highScoreKey, 0);
	}
	
	// Update is called once per frame
	void Update () {
		TrataGameOver ();

		//Gerar inimigo automaticamente
		if (Time.frameCount % 100 == 0) { //Contador
			int inimigoTotal = Random.Range(1, 5);

			for (int i = 0; i <= inimigoTotal; i++) {
				criaInimigo();
			}
		}		      

		marcarScore ();
	}

	public void TrataGameOver() {
		if (IS_GAME_OVER) {
			IS_GAME_OVER = false;
			salvaHighScore();
			SCORE_COUNT = 0;

			Application.LoadLevel("MenuScene");
		}
	}

	public void criaInimigo() {
		var inimigoTransform = Transform.Instantiate (inimigoPrefab);
		inimigoTransform.position = new Vector2 (Random.Range (width * 0.5f, width * 2f), 
		                                         Random.Range(-(height / 2f), height / 2f));
	}

	public void marcarScore () {
		score.text = "Score: " + SCORE_COUNT;
	}

	public void salvaHighScore() {
		if (SCORE_COUNT > highScore) {
			PlayerPrefs.SetInt(highScoreKey, SCORE_COUNT);
			PlayerPrefs.Save();
		}
	}

    public int getHighScore()
    {
        return PlayerPrefs.GetInt(highScoreKey);
    }
}
