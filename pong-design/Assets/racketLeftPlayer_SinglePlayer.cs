using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class racketLeftPlayer_SinglePlayer : MonoBehaviour {

	// Update is called once per frame
    void Update() {
        //controlMouse();
        controlKeyboard();
    
    }

    void controlMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = new Vector3(ray.GetPoint(10f).x, 0.0f, transform.position.z);
    }

    void controlKeyboard()
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