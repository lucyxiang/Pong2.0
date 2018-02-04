// control racket using the mouse

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseControl : MonoBehaviour {

   
    // Update is called once per frame
    void Update()
    {
    	if (transform.position.x < 7.5 || transform.position.x > -7.5){
    		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = new Vector3(ray.GetPoint(10f).x, 0.0f, transform.position.z);
    	}
       
    }

}
