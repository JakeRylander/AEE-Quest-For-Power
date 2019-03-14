using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {
	// Use this for initialization

	public AudioClip accept;
	AudioSource audio;

	void Start () {

		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			Fade.instance.fadeout = 1;
			audio.PlayOneShot (accept, 1.0f);
		}

		if (Fade.instance.finished == 1) {

			Fade.instance.finished = 0;
			SceneManager.UnloadSceneAsync("Menu");
			SceneManager.LoadScene("Stage_1",LoadSceneMode.Additive);
			Debug.Log ("Transitioning Screen");
		
		}
	}
}
