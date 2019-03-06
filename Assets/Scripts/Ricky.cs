using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ricky : MonoBehaviour {
	AudioSource ricky_music;
	bool notentered = true;
	int count;
	// Use this for initialization
	void Start () {
		ricky_music = GetComponent<AudioSource>();
		Debug.Log ("Ricky started");
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ( notentered && transform.position.x < 6) {
			Debug.Log ("has entered ricky");
			notentered = false;
			StageControl.instance.current_event = 3;
		
		}
		if (StageControl.instance.current_event == 3 && count == 0) {

			StartCoroutine (AudioFade.FadeIn (ricky_music, 1.0f));
			count++;

		}
		if (StageControl.instance.current_event == 3) {

			if (transform.position.y > 1) {
			
				transform.Translate (0.0f,-0.010f,0.0f);
			
			}

			if (transform.position.y < 1.5) {

				StageControl.instance.current_event = 4;
			}
		
		}
	}
		
}
