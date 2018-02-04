// control the paddle using "up" and "down" arrow keys

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class racketLeftPlayer : MonoBehaviour {

	 
    // Update is called once per frame
    void Update()
    {
     
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (Input.GetKey("up") && transform.position.x < 7.5)
        {

            transform.position = new Vector3(transform.position.x + 0.2f, 0.0f, transform.position.z);
            Debug.Log(transform.position.x);
        }
        if (Input.GetKey("down") && transform.position.x > -7.5)
        {
            transform.position = new Vector3(transform.position.x - 0.2f, 0.0f, transform.position.z);
            Debug.Log(transform.position.x);
        }

    }
}
