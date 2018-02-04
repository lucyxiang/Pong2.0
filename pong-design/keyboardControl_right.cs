// control the paddle using "W" for up and "S" for down (on the keyboard)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class racketLeftPlayer : MonoBehaviour {

	 
    // Update is called once per frame
    void Update()
    {
     
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (Input.GetKey("w") && transform.position.x < 7.5)
        {

            transform.position = new Vector3(transform.position.x + 0.2f, 0.0f, transform.position.z);
            Debug.Log(transform.position.x);
        }
        if (Input.GetKey("s") && transform.position.x > -7.5)
        {
            transform.position = new Vector3(transform.position.x - 0.2f, 0.0f, transform.position.z);
            Debug.Log(transform.position.x);
        }

    }
}
