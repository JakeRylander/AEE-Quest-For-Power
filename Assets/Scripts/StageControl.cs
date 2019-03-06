using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControl : MonoBehaviour {

	public static StageControl instance;
	public int current_event;
	public AudioClip accept;
	public AudioClip run;
	AudioSource audio;

	IEnumerator Wait(int x, int y){
		yield return new WaitForSeconds (x);
		current_event = y;
	}


	// Use this for initialization
	void Start () {

		current_event = 0;
		instance = this;
		Fade.instance.fadein = 1;
		audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Fade.instance.finished == 1) {

			Fade.instance.finished = 0;
			Debug.Log ("Finished Transition");
			StartCoroutine (Wait(3,1));
		}

		if (current_event == 1) {
		
			if (Input.GetKeyDown (KeyCode.Return)) {
				audio.PlayOneShot (accept, 1.0f);
				current_event = 2;
			}
		}
		if (current_event == 4) {

			StartCoroutine (Wait(3,5));
		
		}
		if (current_event == 6) {
		
			StartCoroutine (Wait(3,7));
		
		
		}
	}
}
