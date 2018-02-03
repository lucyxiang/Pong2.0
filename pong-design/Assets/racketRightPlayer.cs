using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketRightPlayer : MonoBehaviour {

    public GameObject Ball;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Ball.transform.position.x > transform.position.x)
        {

            transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
        }
        if (Ball.transform.position.x < transform.position.x)
        {

            transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
        }
    }
}
