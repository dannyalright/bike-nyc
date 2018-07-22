using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    void Update () {

    }

		void OnGUI () {
			foreach(Touch myTouch in Input.touches) {
				string message = "";
				message += "ID: " + myTouch.fingerId + "\n";
				message += "Phase: " + myTouch.phase.ToString() + "\n";
				message += "ID: " + myTouch.tapCount + "\n";
				message += "Pos X: " + myTouch.position.x + "\n";
				message += "Pos Y: " + myTouch.position.y + "\n";

				int num = myTouch.fingerId;
				GUI.Label(new Rect(0 + 130 * num, 0, 120, 100), message);
			}
		}
}
