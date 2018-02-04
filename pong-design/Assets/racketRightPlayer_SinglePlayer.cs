﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketRightPlayer_SinglePlayer : MonoBehaviour {

    public GameObject sphere;

    // Use this for initialization
    void Start () {
		sphere = GameObject.Find("Ball"); 
    }
	
	// Update is called once per frame
	void Update () {
        if (sphere.transform.position.x > transform.position.x)
        {

            transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
            
        }
        if (sphere.transform.position.x < transform.position.x)
        {
            
            transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
        }
    }
}
