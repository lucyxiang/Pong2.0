using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewSinglePlayerGame(string newSinglePlayerGame) {
		SceneManager.LoadScene(newSinglePlayerGame);
	}
	
	public void NewMultiplayerGame(string newSingleplayerGame) {
		SceneManager.LoadScene(newSingleplayerGame);
	}

	public void Options(string options) {
		SceneManager.LoadScene(options);
	}

	public void Quit() {
		Application.Quit();
	}


	// Update is called once per frame
	public void Update() {
		
	}
}
