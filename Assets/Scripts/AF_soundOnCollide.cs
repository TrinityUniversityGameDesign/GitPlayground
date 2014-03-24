using UnityEngine;
using System.Collections;

public class AF_soundOnCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D other) {
		audio.PlayOneShot(other.gameObject.audio.clip);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
