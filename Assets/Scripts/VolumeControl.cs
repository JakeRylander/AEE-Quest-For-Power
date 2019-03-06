using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour {
	AudioSource menu_music;
	private int count = 0;
	// Use this for initialization
	void Start () {
		menu_music = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return) && count == 0) {
			Debug.Log ("Fading Menu Music");
			StartCoroutine(AudioFade.FadeOut(menu_music, 1.0f));
			count++;
		}
	}
}
