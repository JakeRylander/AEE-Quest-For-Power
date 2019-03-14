using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class privatizado : MonoBehaviour {
	SpriteRenderer text;
	// Use this for initialization
	void Start () {
		text = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (StageControl.instance.current_event == 4) {

			text.enabled = false;
		}
		if (StageControl.instance.current_event == 7) {

			text.enabled = true;

		}
	}
}
