using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketLeftPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = new Vector3(ray.GetPoint(10f).x, 0.0f, transform.position.z);
    }
}
