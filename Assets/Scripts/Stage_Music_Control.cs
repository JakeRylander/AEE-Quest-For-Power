using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Music_Control : MonoBehaviour {
	AudioSource stage_music;
	int count;
	int count2;

	// Use this for initialization
	void Start () {
		stage_music = GetComponent<AudioSource>();
		count = 0;
		count2 = 0;
	}

	// Update is called once per frame
	void Update () {

		if (StageControl.instance.current_event == 1 && count == 0) {
		
			StartCoroutine (AudioFade.FadeIn (stage_music, 1.0f));
			count++;
		
		}
		if (StageControl.instance.current_event == 3 && count2 == 0) {
		
			StartCoroutine (AudioFade.FadeOut (stage_music, 1.0f));
			count2++;
		}
	}
}
