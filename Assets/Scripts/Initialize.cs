using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initialize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene("Menu",LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
