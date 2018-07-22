using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		Touch myTouch = Input.GetTouch(0);

		if (myTouch.phase == TouchPhase.Began) {
			Debug.Log(myTouch.position.x + "\n");

			if (myTouch.position.x < Screen.width/2) {
				Debug.Log("Left side of screen");
			} else {
				Debug.Log("Right side of screen");
			}
			// Debug.Log("touch phase began y'all");
		}



		// if (myTouch.position.x == 1) {
		// 	Debug.Log("is 1");
		// } else {
		// 	Debug.Log("is something else");
		// }
	}
}
