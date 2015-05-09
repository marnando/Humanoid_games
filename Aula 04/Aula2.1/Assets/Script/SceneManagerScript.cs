using UnityEngine;
using System.Collections;

public class SceneManagerScript : MonoBehaviour {

	public void PlayGame () {
		Application.LoadLevel ("PlayGame");
	}

	public void LoadSettings () {
		Application.LoadLevel ("SettingsScene");
	}
}
