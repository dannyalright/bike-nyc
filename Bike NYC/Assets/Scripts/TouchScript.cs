using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    void Update () {
      // Loop through array of touches in case there are multiple at same time
      foreach (Touch touch in Input.touches) {
        // If any of these touches have started this frame
        if (touch.phase == TouchPhase.Began) {
          // ...and if they are on the left side
          if (touch.position.x < Screen.width/2) {
            Debug.Log(touch.fingerId + "\n" + "Left side of screen");
          // ...and if they are on the right side
          } else {
            Debug.Log(touch.fingerId + "\n" + "Left side of screen");
          }
        }
      }
    }

		// void OnGUI () {
		// 	foreach(Touch myTouch in Input.touches) {
		// 		string message = "";
		// 		message += "ID: " + myTouch.fingerId + "\n";
		// 		message += "Phase: " + myTouch.phase.ToString() + "\n";
		// 		message += "Tap Count: " + myTouch.tapCount + "\n";
		// 		message += "Pos X: " + myTouch.position.x + "\n";
		// 		message += "Pos Y: " + myTouch.position.y + "\n";
    //
		// 		int num = myTouch.fingerId;
		// 		GUI.Label(new Rect(0 + 130 * num, 0, 120, 100), message);
		// 	}
		// }
}
