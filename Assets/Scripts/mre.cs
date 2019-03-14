using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mre : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (StageControl.instance.current_event == 5) {

			if (transform.position.y > -1.5) {

				transform.Translate (0.0f,-0.50f,0.0f);

			}

			if (transform.position.y < 0) {

				StageControl.instance.current_event = 6;
			}
		}
	}
}
