using UnityEngine;
using System.Collections;

public class LogoScript : MonoBehaviour {

	public float delayTime = 5f;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (delayTime);
		startMenuScene ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startMenuScene() {
		Application.LoadLevel ("MenuScene");
	}
}
