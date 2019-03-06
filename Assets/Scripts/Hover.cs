using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {

	Vector3 Position = new Vector3 ();
	Vector3 Offset = new Vector3();

	public float amplitude = 15.0f;
	public float frequency = 1.5f;

	// Use this for initialization
	void Start () {
		Offset = transform.position;
		Debug.Log ("Logo set to initial position.");
		amplitude = 0.5f;
		frequency = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {

		Position = Offset;
		Position.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;

		transform.position = Position;
	}
}
