using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStartVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
