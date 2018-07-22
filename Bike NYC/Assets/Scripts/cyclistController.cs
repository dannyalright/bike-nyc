using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclistController : MonoBehaviour {

	public float cyclistSpeed = 60.0f;

	private Rigidbody2D playerRigidbody;


	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {

	}

	// Update is called at a fixed time interval
	// Contain all physics-related code in here
	void FixedUpdate() {
		// bool cycling = Input.GetButton("Fire1");
		// if (cycling) {
		// 	playerRigidbody.AddForce(new Vector2(0, cyclistSpeed));
		// }

		playerRigidbody.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * cyclistSpeed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical")* cyclistSpeed, 0.8f));
	}
}
