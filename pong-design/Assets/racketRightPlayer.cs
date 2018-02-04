using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketRightPlayer : MonoBehaviour {

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
            //Debug.Log("bigger than x");
        }
        if (sphere.transform.position.x < transform.position.x)
        {
            //Debug.Log("smaller than x");
            transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
        }
    }
}
