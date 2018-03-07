using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private bool spacePressed;
	public float force;

	// Use this for initialization
	void Start () {
		spacePressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && !spacePressed) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force), ForceMode2D.Impulse);
			spacePressed = true;
		} else {
			spacePressed = false;
		}
	}
}
