using UnityEngine;
using System.Collections;

public class BounceForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y < 0.0) {
			print(rigidbody.velocity);
			rigidbody.AddForce (Vector3.Scale(rigidbody.velocity, new Vector3(0,-2,0)));
		}
	}
}
