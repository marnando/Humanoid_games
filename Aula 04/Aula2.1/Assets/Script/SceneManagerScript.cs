using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneManagerScript : MonoBehaviour {


    public Text Score;
    protected int MaxScore;
    string highScoreKey = "HighScore";

    public void Update()
    {
        MaxScore = PlayerPrefs.GetInt(highScoreKey);
        Score.text = "Maximo Escore: " + MaxScore;
    }

	public void PlayGame () 
    {
        Application.LoadLevel ("PlayGame");
	}

	public void LoadSettings () 
    {
		Application.LoadLevel ("SettingsScene");
	}
}
