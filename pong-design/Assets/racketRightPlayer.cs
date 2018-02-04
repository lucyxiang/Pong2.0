using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketRightPlayer : MonoBehaviour {

    public GameObject sphere;

    // Use this for initialization
    void Start () {
		sphere = GameObject.Find("Ball");

        /*
        // easy mode
        InvokeRepeating("SlowUpdate", 0.0f, 0.055f);
        */

        // normal mode
        InvokeRepeating("SlowUpdate", 0.0f, 0.03f);

        // hard/impossible mode: dont invode slowupdate
    }
	
    void SlowUpdate()
    {
        if (sphere.transform.position.x > transform.position.x && transform.position.x < 7.5f)
        {

            transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
        }
        if (sphere.transform.position.x < transform.position.x && transform.position.x > -7.5f)
        {
            transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
        }
    }

	// Update is called once per frame
	void Update () {
        
    }
}
