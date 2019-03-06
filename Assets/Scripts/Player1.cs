using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	AudioSource run;
	// Use this for initialization
	void Start () {

		run = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

		if (StageControl.instance.current_event == 2) {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			if (moveHorizontal != 0) {
		
				Debug.Log ("player moving");
				run.playOnAwake = true;
				run.enabled = true;
				run.loop = true;
			} else {
			
				Debug.Log ("player not moving");
				run.enabled = false;
				run.enabled = false;
			}
		}	
	}
}