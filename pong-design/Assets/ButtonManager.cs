﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void changeScene(string scene) {
		SceneManager.LoadScene(scene);
	}

	public void Quit() {
		Application.Quit();
	}


	// Update is called once per frame
	public void Update() {
		
	}
}
