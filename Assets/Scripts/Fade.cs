using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

	public static Fade instance;
	public int fadein;
	public int fadeout;
	RawImage Fader;
	Color fade;
	float tofade;
	public int finished;

	// Use this for initialization
	void Start () {
		Fader = GetComponent<RawImage> ();
		fadein = 0;
		fadeout = 0;
		tofade = 0.0f;
		instance = this;
		finished = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (fadeout == 1) {
				tofade = tofade + 0.02f;
				Fader.color = new Color(0.0f,0.0f,0.0f,tofade);
			if (tofade > 1.0f) {

				finished = 1;
				tofade = 1.0f;
				fadeout = 0;
			
			}
		}
		if (fadein == 1) {
			tofade = tofade - 0.02f;
			Fader.color = new Color (0.0f, 0.0f, 0.0f, tofade);

			if (tofade < 0.0f) {

				finished = 1;
				tofade = 0.0f;
				fadein = 0;
			}
			
		
		}


	}
}
