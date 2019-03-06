using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(fade());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator fade() {
		while (true) {
			yield return new WaitForSeconds (1);
			gameObject.GetComponent<Renderer> ().enabled = false;
			yield return new WaitForSeconds (1);
			gameObject.GetComponent<Renderer> ().enabled = true;
		}
	}
}
