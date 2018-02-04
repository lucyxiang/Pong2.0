using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewSinglePlayerGame(string newSinglePlayerGame) {
		SceneManager.LoadScene(newSinglePlayerGame);
	}
	
	// Update is called once per frame
	public void Update() {
		
	}
}
