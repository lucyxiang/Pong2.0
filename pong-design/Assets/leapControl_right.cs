using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using Leap;

public class leapControl_right : MonoBehaviour {

	Controller controller;

	// Use this for initialization
	void Start () {
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		controller = new Controller ();
<<<<<<< HEAD

		Frame current = controller.Frame ();
		Frame previous = controller.Frame (1);

		HandList hands = current.Hands;
		Hand firstHand = current.Hands.Rightmost;
		Vector handCenter = firstHand.PalmPosition;

		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

		Vector linearMovement = current.Translation (previous);
=======

		Frame current = controller.Frame ();
		Frame previous = controller.Frame (1);

		HandList hands = current.Hands;
		Hand firstHand = current.Hands.Rightmost;
		Vector handCenter = firstHand.PalmPosition;

		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

		Vector linearMovement = current.Translation (previous);

>>>>>>> d75596839881c3e5aa636ef5e95b7195c5f6436a

		float TheLeapY = (float) (handCenter.y - 100);
		float TheVecY = (float) (TheLeapY / 19.3333333333 - 7.5);

<<<<<<< HEAD
		float TheLeapY = (float)(handCenter.y-100);
		float TheVecY = (float)((TheLeapY/19.3333333333)-7.5);



		if ((handCenter.x>0)&&(TheVecY<7.5)&&(TheVecY>-7.5)){


			Debug.Log ("The Y value is:" + linearMovement.y);
			transform.position = new Vector3 (TheVecY, 0.0f, transform.position.z);
			Debug.Log ("The Hand Position is:" + handCenter);


=======
		Debug.Log ("The Y value is:" + linearMovement.y);
		Debug.Log ("The Hand Position is:" + handCenter);
		if((handCenter.x > 0) && (TheVecY < 7.5) && (TheVecY > -7.5)) {
			// Debug.Log ("The Y value is:" + linearMovement.y);
			transform.position = new Vector3 (TheVecY, 0.0f, transform.position.z);
			// Debug.Log ("The Hand Position is:" + handCenter);
>>>>>>> d75596839881c3e5aa636ef5e95b7195c5f6436a
		}
	}
}