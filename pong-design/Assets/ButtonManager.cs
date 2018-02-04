using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void changeScene(string scene) {
		//StartCoroutine(PlayAudio(scene));
		SceneManager.LoadScene(scene);
	}

	IEnumerator PlayAudio(string scene)
    {
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene(scene);
    }
	public void Quit() {
		Application.Quit();
	}


	// Update is called once per frame
	public void Update() {
		
	}
}
