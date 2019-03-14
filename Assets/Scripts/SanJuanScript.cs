using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanJuanScript : MonoBehaviour {

	SpriteRenderer sprite;
	Color fade;
	float tofade;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		tofade = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (StageControl.instance.current_event == 1) {

			tofade = tofade - 0.02f;
			sprite.color = new Color (1.0f, 1.0f, 1.0f, tofade);

			if (tofade < 0.0f) {
				tofade = 0.0f;
			}
		
		}

	}
}
