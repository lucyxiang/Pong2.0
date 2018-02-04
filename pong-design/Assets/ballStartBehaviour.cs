﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballStartBehaviour : MonoBehaviour {

    //Integeres for Ball Control
    int Invert;
    public int TowardsPlayer = 1;
    private Rigidbody myRigidbody;
    public float speed = 30;

    // Use this for initialization
    void Start () {
        Invert = 1;
        TowardsPlayer = 1;
        this.myRigidbody = this.GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(10.0f, 0.0f, 15.0f);
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (transform.position.z < -5.5f)
        {


            //GameObject.Find("Main Camera").GetComponent<Score>().IncreaseScore(1);
            Start();
            transform.position = Vector3.zero;

        }
        if (transform.position.z > 5.5f)
        {

            //GameObject.Find("Main Camera").GetComponent<Score>().IncreaseScore(2);

            Start();
            transform.position = Vector3.zero;

        }
        */
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.tag == "RacketLeft")
        {
            Invert = Invert * -1;
            myRigidbody.velocity = new Vector3(10.0f * Invert, 0.0f, -15.0f * TowardsPlayer); 

        }
        else if (collision.collider.tag == "RacketRight")
        {
            TowardsPlayer = 1;
            myRigidbody.velocity = new Vector3(10.0f * Invert, 0.0f, 15.0f);
            Debug.Log("touched right racket");
        }
        else if (collision.collider.tag == "WallLeft")
        {
            Application.Quit();
            Debug.Log("right player wins");
        }
        else if (collision.collider.tag == "WallRight")
        {
            Application.Quit();
            Debug.Log("left player wins");
        }
    }
}
